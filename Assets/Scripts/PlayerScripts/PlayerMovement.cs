using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control movement speed

    void Update()
    {
        // Get input from the Horizontal and Vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the movement vector to ensure consistent speed in all directions
        movement.Normalize();

        // Move the player using the Rigidbody component (assuming it's attached to the GameObject)
        // You may need to attach a Rigidbody component to your GameObject if you haven't already
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = movement * speed;
    }
}
