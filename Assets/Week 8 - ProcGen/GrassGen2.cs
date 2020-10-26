using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGen2 : MonoBehaviour
{
    public GameObject grassBlade;
    public int grassCounterMax = 1000;

    void Start()
    {
        int grassCounter = 0;

        while(grassCounter < grassCounterMax)  
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-40f, 40f),
                                                Random.Range(-40f, 40f));

            GameObject newGrass = Instantiate(grassBlade, spawnPosition, Quaternion.Euler(0,0,Random.Range(-180,180)));

            // random range for all RGB colors
            newGrass.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));

            grassCounter += 1;
        }      
    }


}
