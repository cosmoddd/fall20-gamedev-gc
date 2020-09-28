using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest2 : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
 
    void OnTriggerEnter2D(Collider2D other)
    {
        camera1.enabled = false;
        camera2.enabled = true;
    }



}
