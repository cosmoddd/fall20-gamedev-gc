
using UnityEngine;

public class RaycastGroundCheck : MonoBehaviour
{
    public float maxDistance = 1;
    SpriteRenderer thisSprite;

    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        // 1 declare the ray in update, right at the point of origin and point it DOWN
        Ray myRay = new Ray(transform.position, Vector2.down);

        // 2 set the raycast's max distance  

        // 3 draw a debug line that shows the ray being drawn
				//   with info being fed from myRay
        Debug.DrawRay(myRay.origin, myRay.direction * maxDistance, Color.white);

        // 4 actually shoot the raycast.  
				//  	shoots it every frame.  if it hits... do something cool
        if (Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance))
        {
            // if true: it hit someting.  fire off a message:
            Debug.Log("YA HIT SOMETHING!");
            thisSprite.color = Color.red;
        }
        else
        {
            thisSprite.color = Color.white;
        }
    }
}
