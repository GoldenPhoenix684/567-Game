using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    private int lives;
    public TextMeshProUGUI LifeText;
    public int highscore;
    
    public int Lives
    {
        get { return lives; }
        set { lives = value; }
    }
    public void SetLives()
    {
        lives = 3;
    }
    // Update is called once per frame
    public void Start()
    {
        lives = 3;
        score = 0;
        UpdateScore(0);
        UpdateLives(0);
       
    }
    void Update()
    {
        
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score.ToString();
        if (score > PlayerPrefs.GetInt("HighScoress"))
        {
            PlayerPrefs.SetInt("HighScoress", score);
        }
        
    }
    public void UpdateLives(int Livestotake)
    {
        Lives += Livestotake;
        LifeText.text = "x " + Lives.ToString();
    }

    

    
}
