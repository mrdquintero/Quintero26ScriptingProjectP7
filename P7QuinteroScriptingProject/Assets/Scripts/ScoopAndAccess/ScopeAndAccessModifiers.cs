using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{

    //creating a public variable that can be accessed by other scripts
    public int alpha = 5;

    //create 2 private virables that can only be accessed by this script
    private int beta = 0;
    private int gamma = 5;

    //creating a method that can be accessed by other scripts

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);


    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log("The answer is: " + answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
