
using UnityEngine;

public class RaycastGroundCheck2 : MonoBehaviour
{
    public float maxDistance = 1f;

    SpriteRenderer thisSprite;

    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 1 declare the ray in Update right at the point of origin
        Ray myRay = new Ray (transform.position, Vector2.down);

        // 2 set max distance (already did that)

        // 3 draw a line that shows the ray
        Debug.DrawRay(myRay.origin, myRay.direction * maxDistance, Color.white);

        if (Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance))
        {
            print("HIT!!!");
            thisSprite.color = Color.red;
        }

        else
        {
            thisSprite.color = Color.white;
        }
    }
}
