using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag.
        if (other.CompareTag("Player"))
        {
            // Find the GameManager script and call the AddCollectedCoin method.
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddCollectedCoin(1); // Increase CollectedCoin by 1.
            }

            // Destroy the collectible object.
            Destroy(gameObject);
        }
    }
}