
using UnityEngine;

public class SimpelPhysicsMovement : MonoBehaviour
{
    public SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 60;
    public float jumpForce = 10;
    public bool onPlatform;
    public GroundCheck groundCheckScript;
    public float gravityInAir = 2f;

    public Vector3 movementVector;


    void Start()
    {
        GetComponent<Rigidbody2D>();

    }

    public bool moving;

    // Physics for left to right movement happens here
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            thisRigidbody2D.AddForce(Vector2.left * force, ForceMode2D.Impulse);
            thisSprite.flipX = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            thisRigidbody2D.AddForce(Vector2.right * force, ForceMode2D.Impulse);
            thisSprite.flipX = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // Space bar triggers jump instantly.
        {
            if (groundCheckScript.isGrounded)
            {
                thisRigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if (groundCheckScript.isGrounded == true)
        {
            thisRigidbody2D.gravityScale = 1;
        }

        else
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }
    }

}
