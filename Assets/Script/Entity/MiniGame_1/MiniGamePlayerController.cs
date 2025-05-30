using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MiniGamePlayerController : MonoBehaviour
{
    //baseController를 상속받기엔 구조가 너무 다른데?

    Animator animator = null;
    Rigidbody2D rigidbody = null;

    private float flpaForce = 6f;
    private float forwardSpeed = 3f;
    public bool isDead = false;

    bool isFlap = false;
    bool isStart = false;

    MiniGame1Manager gameManager = null;

    private void Start()
    {
        gameManager = MiniGame1Manager.Instance;
        animator = GetComponentInChildren<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        if (animator == null) return;
        if (rigidbody == null) return;

    }
   private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isStart == false)
        {
            gameManager.GameStart();
            isStart = true;
        }
        if (isDead)
        {
            return;
        }
        else
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isStart == true )
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return;
                isFlap = true;
            }
        }
    
       
    }

    private void FixedUpdate()
    {
        if (isDead) return;

        Vector3 velocity = rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flpaForce;
            isFlap = false ;
        }

        rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0,0,angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isDead) return;

        animator.SetInteger("isDie", 1);
        isDead = true;
        gameManager.GameOver();
    }
}
