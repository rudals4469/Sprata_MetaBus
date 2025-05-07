using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public  Animator animatior;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("sting"))
        {
            animatior.SetInteger("isHit", 1);
            Invoke("OffSting", 1f);

        }
    }


    public void OffSting()
    {
        animatior.SetInteger("isHit", 0);
    }
}
