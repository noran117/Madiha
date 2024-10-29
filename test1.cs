using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    int playerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        while(playerLives > 0)
        {
            if (playerLives == 3)
                Debug.Log("Many lives");
            else if (playerLives == 2)
                Debug.Log("There are two lives left");
            else 
                Debug.Log("The last life");
            playerLives--;
            
        }
        Debug.Log("Game Over!");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
