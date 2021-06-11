using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{   public string player;
    public int score = 3;
    public string hiPlayer = "Darrel";
    public int hiScore = 7;
    public GameObject inputField;

    public void ManageSceneMenu(){

       
        player =inputField.GetComponent <Text>().text;

        PlayerPrefs.SetString("curPlayer",player);
        PlayerPrefs.SetInt("curScore",score);
        PlayerPrefs.SetString("TopPlayer",hiPlayer);
        PlayerPrefs.SetInt("TopScore",hiScore);
        
        PlayerPrefs.Save();
       
        
         Debug.Log ("Loadscene 611 MENU hit");
         Debug.Log (player +" P1S "+ score + " end" );
         Debug.Log (hiPlayer +" P2S "+ hiScore);

         SceneManager.LoadScene ("main");
     }
}
