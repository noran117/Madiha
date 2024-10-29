using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignmet : MonoBehaviour
{
    
    void Start()
    {
        //Assignment 8
        while (true)
        {
            int number = Random.Range(0, 21);
            if (number == 5)
                continue;
            if (number == 15)
            {
                Debug.Log(number + " \nGame over..");
                break;
            }
            Debug.Log(number);
        }

        Debug.Log("////////////////////");


        string[] funnyWords = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string funnySentence = "";
        int counter = 0;
        while (counter < 7)
        {
            int index = Random.Range(0, funnyWords.Length);
            funnySentence += funnyWords[index] + " ";
            counter++;

        }
        Debug.Log(funnySentence + " ");



    }


}
