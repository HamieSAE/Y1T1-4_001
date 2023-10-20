using UnityEngine;

public class CombinedGoalScript : MonoBehaviour
{
    // Rotation variables
    public float rotationSpeed = 50f;

    // Movement variables
    public float moveSpeed = 1.0f;
    public float amplitude = 1.0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
        // Rotate the object around its axis continuously
        RotateObject();

        // Move the object in a vertical oscillation pattern
        MoveObject();
    }


    void RotateObject()
    {
        // Rotate the object around its axis continuously.
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }

    void MoveObject()
    {
        // Calculate the vertical movement using Mathf.Sin to create an oscillation effect.
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        // Update the object's position by adding the vertical movement to its initial position.
        Vector3 newPosition = startPos + Vector3.up * verticalMovement;
        transform.position = newPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Batman"))
        {
            // Destroy the game object when it collides with the player
            Destroy(gameObject);
        }
    }
}
