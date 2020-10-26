using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGen3 : MonoBehaviour
{
    public GameObject grassBlade;
    public int grassCounterMax = 10;

    void Start()
    {
        int grassCounter = 0;
        
        while (grassCounter < grassCounterMax)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-40f, 40f), Random.Range(-40f, 40f));
            GameObject newGrass = Instantiate(grassBlade, spawnPosition, Quaternion.Euler(0, 0, Random.Range(-180, 180)));
            newGrass.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 10f), Random.Range(0f, 10f), Random.Range(0f, 10f));
            grassCounter++;
        }
    }
}
