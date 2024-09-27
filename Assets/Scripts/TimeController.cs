using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : BaseController<TimeController >

{
    public TMPro.TextMeshProUGUI timerText;
    public float startTime = 60.0f;  // Starting time in seconds
    public float currentTime;       // Current countdown time


    public delegate void TimeEvent();
     public event TimeEvent OnTogglePause;

    // Reference to the GameController
    private GameController gameController;
 
    private bool isTimerRunning = true;

    void Start()
    {
        currentTime = startTime;     // Set the current time to the starting time
        UpdateTimerText();           // Initialize the timer display
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // Reduce the current time based on real time passed
            currentTime -= Time.deltaTime;

            // If time runs out, stop the timer
            if (currentTime <= 0)
            {
                currentTime = 0;
                isTimerRunning = false;
                EndGame();
                // You can trigger a game over or other event here when the time runs out
            }
            if (currentTime <= 0 )
                if(this.OnTogglePause != null)
                    this.OnTogglePause.Invoke();
            // Update the timer display every frame
            UpdateTimerText();
        }
    }

    // Call this method when a fruit is picked up to add time
    public void AddTime(float extraTime)
    {
        currentTime += extraTime;
        UpdateTimerText();  // Update the UI after adding time
    }

     private void EndGame()
    {
        // Trigger game over logic in GameController
        if (gameController != null)
        {
            gameController.EndGame(); // Call the EndGame method from GameController
           
        }

        Debug.Log("Game Over: Timer has reached 0.");
    }


    // Updates the UI Text element with the current time
    void UpdateTimerText()
    {
        // Display the time in minutes and seconds (MM:SS format)
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        int milliseconds = Mathf.FloorToInt((currentTime * 1000) % 1000);
        // Format the time and display it
         timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
