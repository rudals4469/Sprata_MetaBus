using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_MiniGame_2 : MonoBehaviour
{
    [SerializeField] public Button YesButton;
    [SerializeField] public Button NoButton;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI bestComboText;

    private void Start()
    {
        int bestScore_miniGame = PlayerPrefs.GetInt("BestScore2", 0);
        int bestCombo_miniGame = PlayerPrefs.GetInt("BestCombo2", 0);

        bestScoreText.text = $"Max Score: {bestScore_miniGame}";
        bestComboText.text = $"Max Combo: {bestCombo_miniGame}";
    }
    private void Awake()
    {
        YesButton.onClick.AddListener(OnClickYesButton);
        NoButton.onClick.AddListener(OnClickNoButton);
    }

    public void OnClickYesButton()
    {
        Debug.Log("yes");
        SceneManager.LoadScene("MiniGameScene_2");

    }

    public void OnClickNoButton()
    {
        Application.Quit();
    }
}
