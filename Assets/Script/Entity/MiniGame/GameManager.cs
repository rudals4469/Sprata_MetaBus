using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    MiniGameUIManager uiManager;

    private const string BestScoreKey = "BestScore";

    public MiniGameUIManager UIManager
    {
        get { return uiManager; } 
    }
    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;
    private int bestScore = 0;

    private void Awake()
    {
        gameManager = this;
        uiManager = FindAnyObjectByType<MiniGameUIManager>();
    }

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        uiManager.UpdateScore(currentScore);
        BestScore();
        Time.timeScale = 0;

    }
    public void GameOver()
    {
        ScoreManager.instance.currentScore = 0;
        Debug.Log("Game Over");
        uiManager.SetRestart();

    }

    public void GameStart()
    {
        uiManager.Ready();
        Time.timeScale = 1;
    }

    public void EndGane()
    {
        
        ScoreManager.instance.SaveHighScore();
        PlayerPrefs.SetInt("LastScore",ScoreManager.instance.currentScore);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");

    }

    public void AddScore(int score)
    {
        currentScore += score;

        if (currentScore >= bestScore)
        {
            bestScore = currentScore;
        }

        uiManager.UpdateScore(currentScore);
        BestScore();
        Debug.Log("Score: " + currentScore);
    }

    public void BestScore()
    {
        uiManager.BestScore(bestScore);
        PlayerPrefs.SetInt(BestScoreKey, bestScore);
    }

}