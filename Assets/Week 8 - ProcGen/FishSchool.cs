using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSchool : MonoBehaviour
{
    
    public GameObject fishPrefab;
    public List<GameObject> myFishList;
    public int maxFish = 100;

    void Start()
    {
        int fishCounter = 0;

        while (fishCounter < maxFish)
        {
            // set the place to spawn the fish
            Vector3 spawnPos = new Vector3(Random.Range(10f, 10f), Random.Range(-5f,5f), 0);

            // spawn the fish
            GameObject myNewFish = Instantiate(fishPrefab, spawnPos, Quaternion.Euler(0,0,Random.Range(-180f,180f)));

            // add fish to list
            myFishList.Add(myNewFish);

            fishCounter += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            for (int i = 0; i < myFishList.Count; i++)
            {
                myFishList[i].GetComponent<Fiiiish2>().destination = Vector3.zero;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            foreach (GameObject eachFish in myFishList)
            {
                if (eachFish.transform.localScale.x < 2f)
                {
                    eachFish.transform.localScale *= Random.Range(0.5f, 1.5f);
                }
            }            
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject eachFish in myFishList)
            {
                eachFish.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f), Random.Range(.1f, 1f));
            }            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (GameObject eachFish in myFishList)
            {
                eachFish.GetComponent<Fiiiish2>().swimSpeed = Random.Range(-40f, 40f);
            }            
        }
    }
}
