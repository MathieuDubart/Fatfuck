using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : BaseController<GameController>
{
    public delegate void SpeedEvent(float newSpeed);
    public SpeedEvent OnSpeedChanged;

    private float _speed = 1;
 
    public float simulationSpeed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
            if (this.OnSpeedChanged != null)
                this.OnSpeedChanged(value);

            // Update Time.timeScale whenever simulationSpeed is changed
            Time.timeScale = _speed;
        }
    }

    public float? previousSpeed = null;

    public void Start()
    {
        InputController.Instance().OnTogglePause += TogglePause;
        TimeController.Instance().OnTogglePause += TogglePause;
    }

    public void TogglePause()
    {
        if (this.simulationSpeed == 0)
        {
            // If the game is paused, resume it by setting the speed back to the previous speed
            if (this.previousSpeed.HasValue){
                this.simulationSpeed = this.previousSpeed.Value;
                Debug.Log(simulationSpeed);
            }
            else{
                this.simulationSpeed = 1; // Default to normal speed if no previous speed is stored
            
            }
                
                
        }
        else
        {
            // If the game is not paused, store the current speed and pause the game
            this.previousSpeed = this.simulationSpeed;
            this.simulationSpeed = 0;
        }
    }

    public void EndGame()
    {
        Debug.Log("Game Over triggered by TimeController.");

        // Stop the game by setting the time scale to 0
        Time.timeScale = 0;
        this.simulationSpeed = 1;
        this.TogglePause();
        // Additional game-over logic, such as stopping fruit spawning
        // or showing a game-over screen, can go here.
    }

    
}

    
