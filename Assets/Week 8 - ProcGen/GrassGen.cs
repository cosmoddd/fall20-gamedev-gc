using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGen : MonoBehaviour
{
    public GameObject grassBlade;
    public int grassCounterMax = 500;

    void Start()
    {
        int grassCounter = 0;

        while(grassCounter < grassCounterMax)
        {
            // this is where we actually instantiate the grass

            // get the spawn position... based on the size of the sprite
            Vector2 spawnPosition = new Vector2(
                            Random.Range(-40f, 40f),
                            Random.Range(-40f,40f));
            GameObject newGrass =Instantiate (
                                                grassBlade,
                                                spawnPosition,
                                                Quaternion.Euler(0,0,Random.Range(0,360))
            );

            // newGrass.GetComponent<SpriteRenderer>().color = new Color(Random.Range(.1f,1f),.5f,.5f); // autumn vibes
            newGrass.GetComponent<SpriteRenderer>().color = new Color(.6f,Random.Range(.05f,1f),.5f); // autumn vibes
            grassCounter += 1;
        }
    }


}