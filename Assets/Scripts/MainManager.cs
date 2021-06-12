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
        Debug.Log("     MM41  sb hp "+ hiPlayer);
        hiScore = PlayerPrefs.GetInt("TopScore");

       // MyScoreText.text = "HIGH 1SCORE  " + hiPlayer +"   "+ hiScore;
       


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
    {
              
         MyScoreText.text = "HIGH SCORE TO BEAT " + hiPlayer +"   "+ hiScore;
         textDisplay.GetComponent<Text>().text = "Wel2come  "+ player ;
         Debug.Log("MM68" + hiPlayer+ "P " + player); 

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
               
              //  PlayerPrefs.SetString("TopName",hiPlayer);
              //  PlayerPrefs.SetInt("TopScore",hiScore);
              //  Debug.Log("     MM41"+ hiPlayer);
              //  PlayerPrefs.Save();
                
               

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                               

            }
        if (m_Points> hiScore){
            player = hiPlayer;
            hiScore = m_Points;
            Debug.Log("MM104");
           
                       
            }    
        }
    }

    void AddPoint(int point)
    {
       
        m_Points += point;
        if (m_Points> hiScore){
            hiPlayer = PlayerPrefs.GetString("curPlayer");
            hiScore = m_Points;
            Debug.Log("MM116"+ hiPlayer);
            }
         

        ScoreText.text = $"Your Score : {m_Points}";
        string player = PlayerPrefs.GetString("username");
        
       
       // MyScoreText.text = "HIGH3 SCORE  " + hiPlayer +"   "+ hiScore; 
        Debug.Log("MM124");      
    }
 
    public void GameOver()
    {
        m_GameOver = true;
        Debug.Log("MM130" + hiPlayer);
        PlayerPrefs.SetString("TopName",hiPlayer);
        PlayerPrefs.SetInt("TopScore",hiScore);
        PlayerPrefs.Save();
        GameOverText.SetActive(true);
    }
}
