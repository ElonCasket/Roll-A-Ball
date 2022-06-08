using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int counter = 0;


    void Start()
    {
        Debug.Log("these nuts");
    }

    void Update()
    {
        //if the user preses X
        if(Input.GetKeyDown(KeyCode.X))
        {
            //increment counter
            counter ++;
            //display counter
            Debug.Log("Counter is: " + counter);
        }
        //if the user preses N
        if (Input.GetKeyDown(KeyCode.N))
        {
            //increment counter
            counter++;
            //display counter
            Debug.Log("Counter is: " + counter);
        }
    }
}
