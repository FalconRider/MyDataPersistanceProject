using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// *********************edited by *****************************pg 2021

public class StartGame : MonoBehaviour
{   public string player;
    public int score = 0;
    public string hiPlayer;
    public int hiScore;
    public GameObject inputField;
    public GameObject textDisplay;


    public void ManageSceneMenu(){

       
        player =inputField.GetComponent <Text>().text;

        PlayerPrefs.SetString("curPlayer",player);
        PlayerPrefs.SetInt("curScore",score);
        PlayerPrefs.Save();
     
       
      

         SceneManager.LoadScene ("main");
     }
}
