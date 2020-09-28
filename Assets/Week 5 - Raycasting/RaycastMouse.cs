using UnityEngine;

// usage: put this on your Main Camera (+ make sure it's tagged as MainCamera)
// intent: move a sphere around based on mouse cursor raycast
public class RaycastMouse : MonoBehaviour
{
    public GameObject brush;
    public GameObject paint;

    public Color currentColor;

    public float maxRaycastDistance = 1000f;
	
    public float spinSpeed = 50f;

	// Update is called once per frame
	void Update () {
        
		// STEP 1: define the Ray
		// ScreenPointToRay is *essential* for doing raycast with mouse.  // GET THE PIXEL COORDINATES!
		Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		// STEP 2: define the maximum raycast distance (above)

		// STEP 2B: define a RaycastHit2D variable (we'll get to this later)
        RaycastHit2D mouseHit = Physics2D.Raycast(camRay.origin, camRay.direction, maxRaycastDistance);

		// STEP 3: visualize the raycast!! (optional)
        Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastDistance, Color.red);

        // STEP 4: hit detection (out ray)
        if (mouseHit.collider != null)
        {
            brush.SetActive(true);
            brush.GetComponent<SpriteRenderer>().color = currentColor;

            brush.transform.position = mouseHit.point;

            // STEP 5
            // while mouse is down, spawn some paint!
            if (Input.GetMouseButton(0))
            {

                // STEP 7 ... GET THE INSTANTIATED OBJECTS TO ROTATE WITH THE CUBE
                // or

                GameObject thisPaint = Instantiate(paint, mouseHit.point, Quaternion.identity);
                thisPaint.GetComponent<SpriteRenderer>().color = currentColor;
                thisPaint.transform.SetParent(mouseHit.transform, true);																					
                    
            }

            // STEP 6 
            // while hovering, spin the canvas!
            mouseHit.transform.Rotate(new Vector3(0,0, spinSpeed * Time.deltaTime), Space.Self);
        }
        else
        {
            brush.SetActive(false);
        }
    }
}