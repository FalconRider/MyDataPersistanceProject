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
        Debug.Log("        Welcome Start");
        string player = PlayerPrefs.GetString("curPlayer");
        Debug.Log("   CP    " + player);
        textDisplay.GetComponent<Text>().text = "Welcome  "+ player  ;

        
    }

    
    void Update()
    {
       // string player = PlayerPrefs.GetString("curPlayer");
       textDisplay.GetComponent<Text>().text = "Welcome  "+ player  ;

       // int score = PlayerPrefs.GetInt("score");
        
        Debug.Log("WC UP notstart ");
       

    }
}