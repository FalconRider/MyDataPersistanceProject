using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeName : MonoBehaviour
{
    public string player;
    
    public GameObject textDisplay;

 
    void Start()
    {
        Debug.Log("start ");
         string player = PlayerPrefs.GetString("curPlayer");
         textDisplay.GetComponent<Text>().text = "Welcome  "+ player  ;
     // string pg2name = PlayerPrefs.GetString("username");  
    }

    
    void Update()
    {
        //string player = PlayerPrefs.GetString("curPlayer");

       // int score = PlayerPrefs.GetInt("score");
      //  textDisplay.GetComponent<Text>().text = "Welcome  "+ player  ;
       

    }
}