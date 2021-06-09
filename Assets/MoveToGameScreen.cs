using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

 public class MoveToGameScreen : MonoBehaviour {
     public void ManageSceneGAME(){
         Debug.Log ("Loadscene GAME hit");
         SceneManager.LoadScene ("Game");
     }
 }  