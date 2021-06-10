using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
   // public string hsPlayer= "Fritz" ;
    public int highScore;

    public Text MyScoreText;
    public string pg2name;
    public string oldHighScorer;
    
    // Start is called before the first frame update
    void Start()
    {
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                // saves HSname and HS
                Debug.Log("  at end"+oldHighScorer);
                Debug.Log(highScore);

                PlayerPrefs.SetString("topName",oldHighScorer);
                PlayerPrefs.SetInt("topScore",highScore);

        

       
       
         PlayerPrefs.Save();


            }
        }
    }

    void AddPoint(int point)
    {
        m_Points += point;
        if (m_Points> highScore){
           // public string pg2name;
          //  pg2name = oldHighScorer;

        highScore = m_Points;}
        ScoreText.text = $"Score : {m_Points}";
        string pg2name = PlayerPrefs.GetString("username");
        MyScoreText.text = "HIGH SCORE  " + oldHighScorer +"  " + highScore;
    }
 
    public void GameOver()
    {
        m_GameOver = true;
        GameOverText.SetActive(true);
    }
}
