﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorControll : MonoBehaviour
{
    private Transform player;
    private PlayerController playerController;
    private Rigidbody2D rg2D;
    private Vector2 direction;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform centro;
    [SerializeField] private float velocity;
    private bool isAttack;
    private bool _canAttack;
    private Contador counter;
    private bool enableWave = true;
    [SerializeField] private float maxCounter;
    [SerializeField] private float distance;
    [SerializeField] private float attackRange;
    [SerializeField] private float sideAttackRange;
    [SerializeField] private float attackTime;
    private Contador contador;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

        rg2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        counter = new Contador(maxCounter);
        isAttack = true;

        contador = new Contador(attackTime);

    }

    // Update is called once per frame
    void Update()
    {
        
        ContWaveTime();
        //MoveAnimation();
     
        Attack();
    }

    private void Attack()
    {
        if (isAttack)
        {
            //Debug.Log(Mathf.Abs(Vector2.Distance(player.position, centro.position)));
            if (Mathf.Abs(Vector2.Distance(player.position, centro.position)) < attackRange)
            {
                if (centro.position.x - player.position.x < -sideAttackRange)
                {
                    // direita da bolha, garra esquerda
                    animator.SetBool("ataque_d", true);
                    animator.SetBool("ataque_e", false);
                    animator.SetBool("abraco", false);
                }
                else if (centro.position.x - player.position.x > sideAttackRange)
                {
                    // esquerda da bolha, garra direita
                    animator.SetBool("ataque_d", false);
                    animator.SetBool("ataque_e", true);
                    animator.SetBool("abraco", false);
                }
                else
                {
                    animator.SetBool("ataque_d", false);
                    animator.SetBool("ataque_e", false);
                    animator.SetBool("abraco", true);
                }
            }
        }
        AnimationControl();
    }

    public void StopAttack()
    {
        isAttack = false;
    }
    
    private void MoveAnimation()
    {
        if(Mathf.Abs(player.position.x - transform.position.x) > distance)
        {
            if( transform.position.x - player.position.x < 0)
            {
                // frente da aranha, vai pra direita
                rg2D.velocity = Vector2.right * velocity;
            }
            else
            {
                rg2D.velocity = Vector2.left * velocity;
            }
        }
        else
        {
            rg2D.velocity = Vector2.zero;
        }
    }

    private void ContWaveTime()
    {
        if (!enableWave)
        {
           if(counter.RepeatCountTime())
            {
                enableWave = true;
            }
        }
    }

    public void SetEnableWave(bool enable)
    {
        enableWave = enable;
    }

    public bool GetEnableWave()
    {
        return enableWave;
    }

    public void KillPlayer()
    {
        //Debug.Log("qualquer coisa");
        playerController.GetComponent<PlayerController>().SetHealth(0);
    }

    public void AnimationControl()
    {
        _canAttack = animator.GetBool("_canAttack");
        if (!_canAttack)
        {
            if (contador.RepeatCountTime())
            {
                animator.SetBool("_canAttack", true);
            }
        }
    }

    public void DisableAttack()
    {
        animator.SetBool("_canAttack", false);
    }
}
