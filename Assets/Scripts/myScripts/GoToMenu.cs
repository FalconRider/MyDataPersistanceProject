using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{   public string player;
    public int score = 0;
    public GameObject inputField;

    public void ManageSceneMenu(){

       

        player =inputField.GetComponent <Text>().text;

        PlayerPrefs.SetInt("curScore",score);
        
        PlayerPrefs.Save();
       

        



         Debug.Log ("Loadscene 611 MENU hit");
         Debug.Log (player +" PS "+ score);

         SceneManager.LoadScene ("MENU");
     }
}
