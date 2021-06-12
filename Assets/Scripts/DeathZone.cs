using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;
   
    public Text MyScoreText;
    public int score;
    public int hiScore;
     public string player;
    public string hiPlayer;
    // **************************edited by ****************** pg 2021


    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
       

        PlayerPrefs.SetString("TopPlayer",player);
        PlayerPrefs.SetInt("TopScore",hiScore);
        PlayerPrefs.Save();

        score = 0;
        hiPlayer = PlayerPrefs.GetString("TopPlayer");
        hiScore = PlayerPrefs.GetInt("TopScore");
        Debug.Log("DZ 31");
       
        Manager.GameOver();
    }
}
