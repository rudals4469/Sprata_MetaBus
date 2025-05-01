using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    MiniGameUIManager uiManager;

    public MiniGameUIManager UIManager
    {
        get { return uiManager; } 
    }
    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;

    private void Awake()
    {
        gameManager = this;
        uiManager = FindAnyObjectByType<MiniGameUIManager>();
    }

    private void Start()
    {
        uiManager.updateScore(0);
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.SetRestart();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.updateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

}