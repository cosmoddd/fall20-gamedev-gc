using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysterySpacebarGame : MonoBehaviour
{
    public int myScore = 0;
    public int scoreVictory = 20;

    // Start is called before the first frame update
    void Start()
    {
        print("this is the mystery spacebar game!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myScore ++;
        }

        if (myScore == scoreVictory)
        {
            print("HOOOOOOOOOOOOOOO");
        }
    }
}
