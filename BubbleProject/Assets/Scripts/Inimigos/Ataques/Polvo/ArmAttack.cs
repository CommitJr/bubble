using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAttack : MonoBehaviour
{
    [SerializeField] private AnimatorControl animator;
    private PlayerController onda;

    private void Start()
    {
        onda = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
    }


    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "BolhaRastreio")
        {
            //Debug.Log(collision.tag);
            onda.SetControllerActivate(false);
            //    collision.transform.parent.GetComponent<BubbleController>().enabled = false;
            collision.transform.parent.GetComponent<Rigidbody2D>().simulated = false;
            collision.transform.parent.SetParent(transform);
            collision.transform.localPosition = Vector2.zero;
            animator.StopAttack();
        }
    }
}
