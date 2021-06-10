using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void ManageSceneMenu(){

       

        

        // PlayerPrefs.Save();



         Debug.Log ("Loadscene MENU hit");
         SceneManager.LoadScene ("MENU");
     }
}
