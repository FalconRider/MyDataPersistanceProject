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

        
        PlayerPrefs.SetString("TopPlayer",hiPlayer);
        PlayerPrefs.SetInt("curScore",score);
        PlayerPrefs.Save();

        hiPlayer = PlayerPrefs.GetString("TopPlayer");
        Debug.Log("S28 sb hp  " +hiPlayer);
        hiScore = PlayerPrefs.GetInt("TopScore");
     
       
      

         SceneManager.LoadScene ("main");
     }
}
