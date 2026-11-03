using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    //Creating my 3 variable
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this if statement will call the temperture test function and check if the coffee is too hot or too cold
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        //decrease the temperture of the coffee over time
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //this if statement will check if the coffee is too hot
        if (coffeeTemperature >= hotLimitTemperature)
        {
            Debug.Log("The coffee is too hot");
        }
        //this else if statement will check if the coffee is too cold
        else if (coffeeTemperature <= coldLimitTemperature)
        {
            Debug.Log("The coffee is too cold");
        }
        //this else statement will tell me that the coffee is just right
        else
        {
            Debug.Log("The coffee is just right");
        }
    }
}
