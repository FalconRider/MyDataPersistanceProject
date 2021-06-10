using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;
    public int highScore;
    public string oldHighScorer = "Fritz";
    public Text MyScoreText;


    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Debug.Log("  deathzone"+oldHighScorer);
        Debug.Log(highScore);

        PlayerPrefs.SetString("topName",oldHighScorer);
        PlayerPrefs.SetInt("topScore",highScore);
       // MyScoreText.text = "HIGH SCORE  " + oldHighScorer +"  " + highScore;

        PlayerPrefs.Save();

        Manager.GameOver();
    }
}
