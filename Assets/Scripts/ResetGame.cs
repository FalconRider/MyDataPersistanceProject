


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{

    // Resets high score and high scorer to "No One Yet" and  " 3 "
    // not zero cause i wanna know this worked

    public string hiPlayer = "No One Yet";
    public int hiScore = 4;

    public void ResetMyGame(){
        PlayerPrefs.DeleteAll();
   // PlayerPrefs.SetString("TopName",hiPlayer);
   // PlayerPrefs.SetInt("TopScore",hiScore);
   // PlayerPrefs.Save();
    Debug.Log("Reset18");
    }
}




