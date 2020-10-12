using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPaint : MonoBehaviour
{
    public GameObject brush; // assign object in the world
    public GameObject stamp; // assign prefab

    public float maxRaycastDistance = 1000f;

    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition); // get the point w your mouse

        RaycastHit2D mouseHit = Physics2D.Raycast(camRay.origin, camRay.direction, maxRaycastDistance);

        if (mouseHit.collider != null)
        {
            brush.SetActive(true);
            brush.transform.position = mouseHit.point; // move the brush to where the position is
        }

        if (Input.GetMouseButton(0))
        {
            GameObject thisStamp = Instantiate(stamp, mouseHit.point, Quaternion.identity);  // instantiate the new brush
            thisStamp.transform.SetParent(mouseHit.transform, true);   // parent it to the art board!
        }
    }
}
