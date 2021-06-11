using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// ui
using UnityEngine.UI;

 public class MoveToGameScreen : MonoBehaviour {

     public string theName;
     public GameObject inputField;


     // on start - get previously saved HS and HS user name
     // display hs and prev HSUN

     public void ManageSceneGAME(){

         // save Name,
        theName =inputField.GetComponent <Text>().text;

        PlayerPrefs.SetString("username",theName);

        

         Debug.Log(theName);
       
         PlayerPrefs.Save();



         Debug.Log ("Loadscene GAME hit");
         SceneManager.LoadScene ("main");
     }
 }  