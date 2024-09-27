using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : BaseController<UIController>
{
    public delegate void UIEvent();
    public event UIEvent OnRestartGame;  // Event to invoke when restart button is clicked

    public GameObject restartButton;  // Reference to the restart button UI

    private TimeController timeController;

    void Start()
    {

        TimeController.Instance().OnGameEnded += this.ShowRestartButton;
        // Hide the restart button initially
        if (restartButton != null)
        {
            restartButton.SetActive(false);
        }

        // Hook up the button to the restart method
        if (restartButton != null)
        {
            restartButton.GetComponent<Button>().onClick.AddListener(RestartButtonClicked);
        }
    }

    // Method to show the restart button when the game ends
    public void ShowRestartButton()
    {
        if (restartButton != null)
        {
            restartButton.SetActive(true);
        }
    }

    // Method to handle the restart button click event
    private void RestartButtonClicked()
    {
        if (this.OnRestartGame != null)
        {
            this.OnRestartGame.Invoke();  // Invoke the restart event
        }
    }
}