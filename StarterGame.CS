using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterGame : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    //Initialization 
    void Start()
    {
        StartGame();
    }   

    void StartGame()
    {
        //redefine values to avoid change to max / min / guess
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to essentially a guessing game thing...");
        Debug.Log("Pick a number : ");
        Debug.Log("The Highest Number is : " + max);
        Debug.Log("The Lowest Number is  : " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher | Push Down = Lower | Push Space = Correct ");
        max = max + 1;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("We got it! That means this works... phew...");
            //restarts the game
            StartGame();
        }
    }
    //Shoots back a number to the user and adds base text
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than : " + guess);
    }
}
