using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public  Animator animatior;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("sting"))
        {
            animatior.SetBool("isSting", true);
            Invoke("OffSting", 1f);

        }
    }

    public void OffSting()
    {
        animatior.SetBool("isSting", false);
    }
}
