using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int CollectedCoin = 0;
    private bool isPaused = false;

    // Call this method when a coin is collected.
    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;

        // Check if CollectedCoin reaches 15.
        if (CollectedCoin >= 15)
        {
            // Load the "Won" scene.
            SceneManager.LoadScene("Won");
        }

        // You can add any other logic here, such as updating a UI display of collected coins.
    }
    
    void Update()
    {
        // Check for player input to toggle pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                // Unpause the game
                Time.timeScale = 1.0f;
            }
            else
            {
                // Pause the game
                Time.timeScale = 0.0f;
            }
            isPaused = !isPaused;
        }
    }
}
