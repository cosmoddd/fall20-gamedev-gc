using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D()
    {
        isGrounded = false;
    }
}
