using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;
    private void Update()
    {
        yesButton.onClick.AddListener(OnClickyesButton);
        noButton.onClick.AddListener(OnClicknoButton);
    }

    public void OnClickyesButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnClicknoButton()
    {
        Application.Quit();
    }
}
