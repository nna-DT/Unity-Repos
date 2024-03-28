using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is " + max);
        Debug.Log("Lowest number is " + min);
        Debug.Log("Tell me your number is higher or lower than 500");
        Debug.Log("Push up = higher, down = lower, enter = correct");
        //print("Welcome to number wizard; print");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow is pressed");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow is pressed");
            max = guess; 
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter is pressed");
        }
    }
}
