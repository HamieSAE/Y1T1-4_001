using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int CollectedCoin = 0;

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
}
