using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    private GameManager gameManager;
    public TextMeshProUGUI HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScoress");
    }

    public void HighScores()
    {
        
    }
}
