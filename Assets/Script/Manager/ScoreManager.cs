using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int currentScore = 0;
    public int bestScore = 0;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        AddScore(currentScore);
        BestScore();
    }

    public void AddScore(int score)
    {
        currentScore += score;
    }

    public void BestScore()
    {
        if (currentScore >= bestScore)
        {
            bestScore = currentScore;
        }
    }


    public void SaveHighScore()
    {
        bestScore = PlayerPrefs.GetInt("HighScore", 0);

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("HighScore",bestScore);
            PlayerPrefs.Save();
        }
    }

}
