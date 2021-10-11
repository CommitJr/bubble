using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorControll : MonoBehaviour
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
        // falta encontrar valores melhores para a area de ataque( direita, esquerda e centro )


        direction = (player.position - centro.position);

        // ataque esquerdo
        if (Vector2.Distance(centro.position, player.position) < 3)
        {
            animator.SetBool("ataque_e", true);

            direction = direction.normalized;
            direction *= velocity;
            rg2D.velocity = direction;
        }

        // ataque direito
        if (Vector2.Distance(centro.position, player.position) < 3)
        {
            animator.SetBool("ataque_d", true);

            direction = direction.normalized;
            direction *= velocity;
            rg2D.velocity = direction;
        }

        // ataque central
        if (Vector2.Distance(centro.position, player.position) < 3)
        {
            animator.SetBool("abraco", true);

            direction = direction.normalized;
            direction *= velocity;
            rg2D.velocity = direction;
        }

        else
        {
            rg2D.velocity = Vector2.zero;
            animator.SetBool("ataque_e", false);
            animator.SetBool("abraco", false);
            animator.SetBool("ataque_d", false);
        }
    }
}
