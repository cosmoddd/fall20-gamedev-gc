using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRoomba2 : MonoBehaviour
{

    public float roombaDetectionDistance = 2f;
    public float roombaSpeed = 4f;


    void Update()
    {

        // Step 1: Define the ray
        // Vector3.up  the world's up positoin
        // transform.up  is y relative to the object
        Ray2D roombaRay = new Ray2D(transform.position, transform.up);

        // Step 2: define max distance

        // Step 3: draw debug

        Debug.DrawRay(roombaRay.origin, roombaRay.direction * roombaDetectionDistance, Color.white);

        // Step 4 shoot the raycast

        if (Physics2D.Raycast(roombaRay.origin, roombaRay.direction, roombaDetectionDistance))
        {
            int randomNumber = Random.Range(0,100);
            if (randomNumber < 50)
            {
                transform.Rotate(new Vector3(0,0,90)); // rotating to the right
            }
            if (randomNumber > 50)
            {
                transform.Rotate(new Vector3(0,0,-90)); // rotating to the left
            }
        }
        else
        {
            transform.Translate(0, Time.deltaTime * roombaSpeed, 0);
        }

    }
}
