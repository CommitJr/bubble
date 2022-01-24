using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostra : MonoBehaviour
{
    private Transform player;
    [SerializeField] private Transform centro;
    [SerializeField] private Animator animator;
    private PlayerController playerController;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Vector2.Distance(centro.position, player.position) < 2)
        {
            animator.SetBool("ataque", true);
        }
        else
        {
            animator.SetBool("ataque", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BolhaRastreio")
        {
            Debug.Log(collision.tag);
            //    collision.transform.parent.GetComponent<BubbleController>().enabled = false;
            collision.transform.parent.GetComponent<Rigidbody2D>().simulated = false;
            collision.transform.parent.SetParent(transform);
            collision.transform.localPosition = Vector2.zero;
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        playerController.GetComponent<PlayerController>().SetHealth(0);
    }
}
