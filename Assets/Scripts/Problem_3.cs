using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_3 : MonoBehaviour
{
    //Call your function with no parameter and call it with "Game Dev is the best!" 
    void Start()
    {
        Pr("Game Dev is the best!");
        Pr();
    }

    //Create a void function called Printer that takes in one string parameter. 
    //Give this parameter a default value of "This is a default value"
    //Make the function print out the parameter. 
     void Pr(string var = "This is a default value")
    {
        print(var);
    }
}
