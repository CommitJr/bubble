using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    #region SCOPE
    private int force;
    private float speedLimit;

    private Collider2D touchCollider;
    private Animator animator;
    #endregion

    #region START
    void Start()
    {
        force = 120;
        speedLimit = 2.5f;

        touchCollider = GameObject.FindWithTag("PlayerController").GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
    }
    #endregion

    #region UPDATE
    void FixedUpdate()
    {
        SpeedController();
    }
    #endregion

    #region SPEED
    private void SpeedController()
    {
        SpeedXAxis();
        SpeedYAxis();
    }

    private void SpeedXAxis()
    {
        if (GetComponent<Rigidbody2D>().velocity.x > speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speedLimit, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (GetComponent<Rigidbody2D>().velocity.x < -speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speedLimit, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    private void SpeedYAxis()
    {
        if (GetComponent<Rigidbody2D>().velocity.y > speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speedLimit);
        }

        if (GetComponent<Rigidbody2D>().velocity.y < -speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -speedLimit);
        }
    }
    #endregion

    #region COLLISION
    void OnTriggerEnter2D(Collider2D foreignObject)
    {
        AnimationController(foreignObject);
    }
    #endregion

    #region ANIMATION
    private void AnimationController(Collider2D foreignObject)
    {
        if (foreignObject.gameObject.CompareTag("PlayerController"))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = new Vector2(transform.position.x - touchPosition.x, transform.position.y - touchPosition.y).normalized;

            if (direction.x > 0)
            {
                AnimationXAxis();
            }

            if (direction.x < 0)
            {
                AnimationYAxis();
            }
        }
    }

    private void AnimationXAxis()
    {
        animator.SetBool("Toque x", true);
        animator.SetBool("Toque y", false);
    }

    private void AnimationYAxis()
    {
        animator.SetBool("Toque x", false);
        animator.SetBool("Toque y", true);
    }

    public void StopAnimation()
    {
        animator.SetBool("Toque y", false);
        animator.SetBool("Toque x", false);
    }
    #endregion
}
