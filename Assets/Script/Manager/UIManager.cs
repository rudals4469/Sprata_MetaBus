using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public Button YesButton;
    [SerializeField] public Button NoButton;

    private void Awake()
    {
        YesButton.onClick.AddListener(OnClickYesButton);
        NoButton.onClick.AddListener(OnClickNoButton);
    }

    public void OnClickYesButton()
    {
        Debug.Log("yes");
        SceneManager.LoadScene("MiniGameScene");
    }

    public void OnClickNoButton()
    {
        Application.Quit();
    }
}
