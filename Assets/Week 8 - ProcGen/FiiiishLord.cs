using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiiiishLord : MonoBehaviour
{

    public GameObject fishPrefab;
    public List<GameObject> myFishList;

    void Start()
    {
        int fishCounter = 0;

        while (fishCounter < 100)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10,10), Random.Range(-5f,5f), 0);

            GameObject myNewFish = Instantiate(fishPrefab, 
                                                spawnPos, 
                                                Quaternion.Euler(0,0,Random.Range(0,360)));
            myFishList.Add(myNewFish);
            fishCounter += 1;         // add one to counter when you add fish.  
                                        // YOU WILL CRASH UNITY IF YOU DON'T DO THIS
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            // for loop cose through the list
            for (int i = 0; i < myFishList.Count; i++)
            {
                myFishList[i].GetComponent<Fiiiish>().destination = Vector3.zero;
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            foreach(GameObject eachFish in myFishList)
            {
                if (eachFish.transform.localScale.x < 2f)
                    eachFish.transform.localScale *= Random.Range(0.5f, 1.5f);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach(GameObject eachFish in myFishList)
            {
                eachFish.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));        
            }
        }
    }
}