using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // Target to follow obj
    public float distance = 5.0f; // Distance
    public float sensitivity = 2.0f; // Sensitivity
    public float heightOffset = 1.5f; // Height offset for camera

    private float rotationX = 0.0f; // Initial vertical rotation
    private float rotationY = 0.0f; // Initial horizontal rotation

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Locks cursor to the middle of the screen
        Cursor.visible = false; // Makes cursor invisible
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
    }

    void HandleCameraInput()
    {
        // Rotate camera based on mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Update camera horizontal rotation based on mouse input
        rotationY += mouseX;

        // Update camera vertical rotation based on mouse input
        rotationX -= mouseY;

        // Clamp the vertical rotation to restrict camera rotation angles between -90 and 90 degrees
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        // Apply the camera rotation
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }

    void LateUpdate()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        // Move the camera to follow the target
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * heightOffset;
        transform.position = targetPosition;
    }
}
