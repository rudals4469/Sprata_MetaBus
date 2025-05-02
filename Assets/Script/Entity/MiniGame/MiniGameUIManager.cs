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

    public Image readyUI;

    public GameManager gameManager;


    private void Awake()
    {
        reStratButton.onClick.AddListener(onClickreStartButton);
        quitButton.onClick.AddListener(onClickquitButton);
    }

    private void Start()
    {
        readyUI.gameObject.SetActive(true);
    }

    public void Ready()
    {
        GameUI.gameObject.SetActive(true);
        GameOverUI.gameObject.SetActive(false);
        readyUI.gameObject.SetActive(false);
    }
    public void SetRestart()
    {
        GameUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        Score.text = score.ToString();
        currentScore.text = score.ToString();
    }

    public void BestScore(int score)
    {
        bestScore.text = score.ToString();
    }

    public void onClickreStartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void onClickquitButton()
    {
        if (gameManager != null)
        {
            gameManager.EndGane();
        }
        else
        {
            Debug.Log("¿Ö¾ÈµÊ");
        }
    }
}
