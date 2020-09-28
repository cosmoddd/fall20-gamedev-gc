using UnityEngine;


public class SimplePhysicsController2D : MonoBehaviour
{
    
    public SpriteRenderer thisSprite;    
    public Rigidbody2D thisRigidbody2D;
    public float force = 10f;

    public GroundCheck2 groundCheckScript;

    public float gravityInAir;

    void Update()
    {
        if (groundCheckScript.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            }

            thisRigidbody2D.gravityScale = 7;
        }

        if (groundCheckScript.isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            thisRigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);

            if (thisSprite.flipX == false)
            {
                thisSprite.flipX = true;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisRigidbody2D.AddForce(-Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);
            
            if (thisSprite.flipX == true)
            {
                thisSprite.flipX = false;
            }
            
        }


    }
}
