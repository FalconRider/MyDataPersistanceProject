using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//********************************edited by ********************* pg 2021

public class MainManager : MonoBehaviour
{
    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public Text ScoreText;
    public GameObject GameOverText;
    
    private bool m_Started = false;
    private int m_Points;
    
    private bool m_GameOver = false;

   // my added variables start here       pg
   
    
    public GameObject textDisplay;
    public Text textWDisplay;
    public Text MyScoreText;

    public int hiScore;
    public int score;
    public string player;
    public string hiPlayer;
    
   
    void Start()
    {  
        player = PlayerPrefs.GetString("curPlayer");
        score = PlayerPrefs.GetInt("curScore");
        hiPlayer = PlayerPrefs.GetString("TopPlayer");
        hiScore = PlayerPrefs.GetInt("TopScore");

        MyScoreText.text = "HIGH SCORE  " + hiPlayer +"   "+ hiScore;
                
        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);
        
        int[] pointCountArray = new [] {1,1,2,2,5,5};
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }
    }

    private void Update()
    {;
        
         MyScoreText.text = "HIGH SCORE  " + hiPlayer +"   "+ hiScore;
         textDisplay.GetComponent<Text>().text = "Welcome  "+ player ;

        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        else if (m_GameOver)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {       
               
                PlayerPrefs.SetString("TopName",hiPlayer);
                PlayerPrefs.SetInt("TopScore",hiScore);
                PlayerPrefs.Save();
               

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                
               

            }
        if (m_Points> hiScore){
            player = hiPlayer;
            hiScore = m_Points;
           
                       
            }    
        }
    }

    void AddPoint(int point)
    {
       
        m_Points += point;
        if (m_Points> hiScore){
            hiPlayer = PlayerPrefs.GetString("curPlayer");
            hiScore = m_Points;}
         

        ScoreText.text = $"Your Score : {m_Points}";
        string player = PlayerPrefs.GetString("username");
        
       
        MyScoreText.text = "HIGH SCORE  " + hiPlayer +"   "+ hiScore;       
    }
 
    public void GameOver()
    {
        m_GameOver = true;
        GameOverText.SetActive(true);
    }
}
