using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeForce : MonoBehaviour
{
    public ConstantForce2D force2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.DrawRay(force2D.force, transform.right*10,Color.red);
    }
}
