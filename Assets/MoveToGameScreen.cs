using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

 public class MoveToGameScreen : MonoBehaviour {

     public string theName;


     // on start - get previously saved HS and HS user name
     // display hs and prev HSUN

     public void ManageSceneGAME(){

         // save Name,

        PlayerPrefs.SetString("username",theName);

        

         Debug.Log(theName);
       
         PlayerPrefs.Save();



         Debug.Log ("Loadscene GAME hit");
         SceneManager.LoadScene ("main");
     }
 }  