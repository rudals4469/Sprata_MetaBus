using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameUIManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI bestScore;
    public Button reStratButton;
    public Button quitButton;

    public GameObject GameUI;
    public TextMeshProUGUI currentScore;


    private void Awake()
    {
        reStratButton.onClick.AddListener(onClickreStartButton);
        quitButton.onClick.AddListener(onClickquitButton);
    }
    private void Start()
    {
        GameUI.gameObject.SetActive(true);
        GameOverUI.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        GameUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(true);
    }

    public void updateScore(int score)
    {
        Score.text = score.ToString();
        currentScore.text = score.ToString();
    }

    public void onClickreStartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void onClickquitButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
