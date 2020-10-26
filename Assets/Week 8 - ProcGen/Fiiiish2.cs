using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiiiish2 : MonoBehaviour
{
    public Vector3 destination;
    public float swimSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
    }

    // Update is called once per frame
    void Update()
    {
        // actually moving the fish
        transform.position = Vector2.MoveTowards(transform.position, destination, swimSpeed *Time.deltaTime);

        // debug line
        Debug.DrawLine(transform.position, destination, Color.cyan);

        // distance code to determine if fish is close - then set new position random
        if(Vector2.Distance(transform.position, destination)< 1f)
        {
            destination = new Vector3 (Random.Range(-40f, 40f),Random.Range(-40f, 40f), 0);
        }

        // helper code to keep fish pointed in the right direction
        transform.right = destination - transform.position;

    }
}
