using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{

    public SmoothCamera smoothCameraScript;

    void OnTriggerStay2D(Collider2D other)
    {
        print(other);
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
