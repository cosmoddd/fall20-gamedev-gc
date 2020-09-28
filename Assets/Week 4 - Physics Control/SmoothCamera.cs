using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;

    private Vector3 velocity = Vector3.zero;

    public bool inDeadZone;

    // time to reset dead zone
    public float maxt;
    // time until camera stops moving
    public float t;

    void FixedUpdate()
    {
            if (inDeadZone == true)
            {
                t = maxt;

            }

            if (inDeadZone == false)
            {
                if (t <=0) return;
                t -= Time.deltaTime;
            }

            // Define a target position above and behind the target transform
            Vector3 targetPosition = target.TransformPoint(new Vector3(0, 3, -10));

            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    
    }
}