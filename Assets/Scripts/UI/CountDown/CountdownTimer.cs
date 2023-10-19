using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    private int countdown = 10;
    private bool isCounting = true;

    void Update()
    {
        if (isCounting)
        {
            // Check if countdown is greater than 0.
            while (countdown > 0)
            {
                Debug.Log("Countdown: " + countdown);

                // Decrement the countdown.
                countdown--;

                // Add a delay (optional).
                // This helps prevent the loop from running too fast.
                // You can adjust the duration to your needs.
                float delayDuration = 1.0f; // 1 second
                float startTime = Time.time;

                while (Time.time < startTime + delayDuration)
                {
                    // Wait for the specified delay duration.
                }
            }

            // The loop has finished when countdown reaches 0.
            // You can perform additional actions here.
            Debug.Log("Countdown finished!");
            isCounting = false; // Stop the countdown.
        }
    }
}
