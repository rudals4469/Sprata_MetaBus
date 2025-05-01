using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayerController : MonoBehaviour
{
    //baseController�� ��ӹޱ⿣ ������ �ʹ� �ٸ���?

    Animator animator = null;
    Rigidbody2D rigidbody = null;

    private float flpaForce = 6f;
    private float forwardSpeed = 3f;
    private bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        if (animator == null) return;
        if (rigidbody == null) return;

    }
    private void Update()
    {
        if(isDead)
        {
            if(deathCooldown > 0)
            {
                deathCooldown -= Time.deltaTime;
            }
        }

        else
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
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
        deathCooldown = 1f;
    }
}
