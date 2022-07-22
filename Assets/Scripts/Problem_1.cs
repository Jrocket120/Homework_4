using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_1 : MonoBehaviour
{
    //Call your custom functions and print out the returns values of boxes 12,4 and 13.5f by 1.3f.
    //You should have 32 and 29.6f as your return print outs. 
    void Start()
    {
        int a = perimeter(12, 4);
        float b = perimeter(13.5f, 1.3f);
        print(a);
        print(b);
    }
    int perimeter(int length,int width)
    
    {
        return 2 * length + 2 * width;
    }
    float perimeter(float length, float width)
    {
        return 2 * length + 2 * width;
    }
    

}
        
    

    //Part 1: 
    //Create a function called Perimeter that takes in two parameters of int length and int width
    //Calculate the perimeter of the box and return the value as an int.


    //Part 2: 
    //Overload the function by creating a float version of the same function 

