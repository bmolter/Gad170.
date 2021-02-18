using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwo : MonoBehaviour

    
    
{
    public string gameName; //A place to hold my game name
    public int hours; // The number of hours i'ved played the game
    public float cost; // The cost of the game
    
   
    // Start is called before the first frame update
    void Start()
    {
        /// This displays the name, cost, and hours i've played this game in the console
        Debug.Log("My favourite game is: " + gameName + " I have played if for" + hours +
            "hrs, it cost me $" + cost + " therefore my dollar per hour is: $" + System.Math.Round( (cost/hours), 2));
       
        float randomNum = Random.Range(1f,10f); //stores a random number for function

        if(randomNum == 1f)
        {
            Debug.Log("The number was one!");
        }

        if(randomNum > 3f)
        {
            Debug.Log("The number was greater than three!");
        }

        if(randomNum >= 3f)
        {
            Debug.Log("The Number was greater than or equal to three!");
        }

        if (randomNum < 3f || (randomNum > 3f && randomNum < 5f))
        {
            Debug.Log("The number was less than three or the number was greater than three, but less than five");
        }
        else
        {
            Debug.Log("Number was four");
        }
        

        //() Parantheses
        //{} curly braces
        //[] Square brackets
        //= gets
        //== equal to
        //; go to next instruction(full stop)
        // little extra f after ie.(3f) indicates a float
        //|| Or
        //&& And
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
        
} 
