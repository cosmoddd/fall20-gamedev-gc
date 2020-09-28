
using UnityEngine;

public class SmoothCamera2 : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;

    Vector3 thisVelocty = Vector3.zero;
    public bool inDeadZone;

    public float maxTime;
    public float currentTime;

    void FixedUpdate()
    {
        if (inDeadZone == true)
        {
            currentTime = maxTime;  // reset the timer when entering dead zone
        }

        if (inDeadZone == false)
        {
            if (currentTime <= 0) return; // if less than 0, return (aka get out of this entire function)

            currentTime -= Time.deltaTime; // countdown 
        }

        // Define a target position slightly above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 3, -10f));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref thisVelocty, smoothTime);
    }
}
