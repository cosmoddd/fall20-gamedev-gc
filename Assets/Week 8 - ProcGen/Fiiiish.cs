using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiiiish : MonoBehaviour
{

    public Vector3 destination;
    public float swimSpeed = 3f;

    void Start()
    {
        // randomize color
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));        
    }
    // heave away boys
    // Always swim, boys
    // HIIII

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, swimSpeed * Time.deltaTime);

        // draw debug line to destination:

        Debug.DrawLine(transform.position, destination, Color.yellow);

        // if we reach our destination, pick a new one:

        if (Vector2.Distance(transform.position, destination)<2f)
        {
            destination = new Vector3( Random.Range(-90f, 90f),   // x pos
                                        Random.Range(-50f,50f),
                                        0); // y pos
                            

        }
        transform.right = destination - transform.position;
    }
}