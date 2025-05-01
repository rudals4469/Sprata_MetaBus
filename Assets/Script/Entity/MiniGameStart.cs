using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameStart : MonoBehaviour
{
    public GameObject interactionPopup;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("미니게임 실행");
            interactionPopup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (other.CompareTag("Player"))
            {

                interactionPopup.SetActive(false);
            }
        }
        
    }
}
