using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public static ShowScore instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highestScoreText;

    int score = 0;
    int highestScore = 0;
    // int life = 3;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highestScore = PlayerPrefs.GetInt("highestScore", 0);
        scoreText.text = score.ToString() + " Points";
        highestScoreText.text = "Highest: " + highestScore.ToString() + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetScore()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";

        if (highestScore < score)
        {
            PlayerPrefs.SetInt("highestScore", score);
        }   
    }
}
