using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPACEBARGAME : MonoBehaviour
{
    public int myScore = 0;
    public int scoreVictory = 20;


    void Start()
    {
        Debug.Log("This is debug log!");
        print("This is print.  And we are starting our experience now!");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Spacebar pressed");
            myScore++;
        }

        if (myScore > scoreVictory)
        {
            print("SPAAAAAMMMM");
        }
    }
}
