using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        //creating an array of strings
        string[] strings = new string[3];

        //give each element in the array a string value
        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Third String";

        foreach (string item in strings)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
