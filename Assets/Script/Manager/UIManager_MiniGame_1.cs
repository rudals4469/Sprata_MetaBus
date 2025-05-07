using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_MiniGame_1 : MonoBehaviour
{
    [SerializeField] public Button YesButton;
    [SerializeField] public Button NoButton;
    public TextMeshProUGUI bestScoreText;

    private void Start()
    {
        int bestScore_miniGame = PlayerPrefs.GetInt("BestScore", 0);

        bestScoreText.text = $"Max Score: {bestScore_miniGame}";
    }
    private void Awake()
    {
        YesButton.onClick.AddListener(OnClickYesButton);
        NoButton.onClick.AddListener(OnClickNoButton);
    }

    public void OnClickYesButton()
    {
        Debug.Log("yes");
        SceneManager.LoadScene("MiniGameScene_1");
    }

    public void OnClickNoButton()
    {
        Application.Quit();
    }
}
