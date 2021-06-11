using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;
    public int hiScore;
   
    public Text MyScoreText;

     public string player;
    public string hiPlayer;


    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Debug.Log("  deathzone");

        PlayerPrefs.SetString("topName",player);
        PlayerPrefs.SetInt("topScore",hiScore);

       
      
        PlayerPrefs.Save();

        Manager.GameOver();
    }
}
