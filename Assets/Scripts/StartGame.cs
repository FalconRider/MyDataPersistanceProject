using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// *********************edited by *****************************pg 2021

public class StartGame : MonoBehaviour
{   public string player;
    public int score = 0;
    public string hiPlayer = "DHP";
    public int hiScore;
    public GameObject inputField;
    public GameObject textDisplay;


    public void ManageSceneMenu(){

       
        player = inputField.GetComponent <Text>().text;

        PlayerPrefs.SetString("topPlayer",hiPlayer);
        PlayerPrefs.SetInt("curScore",hiScore);               
        PlayerPrefs.SetString("curPlayer",player);
        PlayerPrefs.SetInt("curScore",score);
        

        hiPlayer = PlayerPrefs.GetString("topPlayer");       
        hiScore = PlayerPrefs.GetInt("TopScore");

         Debug.Log("S28 sb hp  " +hiPlayer);
     
         SceneManager.LoadScene ("main");
     }
}
