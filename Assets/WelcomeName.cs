using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeName : MonoBehaviour
{
    public string pg2name;
    
    public GameObject textDisplay;

 
    void Start()
    {
      string pg2name = PlayerPrefs.GetString("username");  
    }

    
    void Update()
    {
        string pg2name = PlayerPrefs.GetString("username");

       // int score = PlayerPrefs.GetInt("score");
        textDisplay.GetComponent<Text>().text = "Welcome   "+ pg2name +"  to the game " ;
       

    }
}