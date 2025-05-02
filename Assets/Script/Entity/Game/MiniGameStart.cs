using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameStart : MonoBehaviour
{
    public GameObject interactionPopup;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("�̴ϰ��� ����");
            interactionPopup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
            if (other.CompareTag("Player"))
            {
                if(interactionPopup != null)
                {

                    interactionPopup.SetActive(false);
                }
            }
        
    }
}
//if (SceneManager.GetActiveScene().buildIndex == 0)