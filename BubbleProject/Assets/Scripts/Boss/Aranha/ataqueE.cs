using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ataque da garra esquerda
public class ataqueE : MonoBehaviour
{
    private Transform player;
    private Rigidbody2D rg2D;
    private Vector2 direction;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform centro;
    [SerializeField] private float velocity;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        rg2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        direction = (player.position - centro.position);

        if (Vector2.Distance(centro.position, player.position) < 3)
        {
            animator.SetBool("ataque_e", true);

            direction = direction.normalized;
            direction *= velocity;
            rg2D.velocity = direction;
        }

        else
        {
            rg2D.velocity = Vector2.zero;
            animator.SetBool("ataque_e", false);
        }
    }
}
