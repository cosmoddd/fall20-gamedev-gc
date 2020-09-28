using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone2 : MonoBehaviour
{

    public SmoothCamera2 smoothCameraScript;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            smoothCameraScript.inDeadZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            smoothCameraScript.inDeadZone = false;
        }
    }
}
