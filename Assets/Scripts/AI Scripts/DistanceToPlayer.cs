using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    // Drag and drop the player's GameObject into this field in the Inspector.
    public Transform player; 
    // Adjust the detection distance in the Inspector.
    public float detectionDistance = 5.0f; 

    void Update()
    {
        // Calculate the distance between this GameObject and the player.
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Check if the player is close enough.
        if (distanceToPlayer <= detectionDistance)
        {
            // Display a message when the player is close enough.
            Debug.Log("Player is close enough");
        }
    }
}
