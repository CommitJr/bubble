using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lulaAtack : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Animator animator;
    private float distancia;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        distancia = Vector3.Distance(player.transform.position, transform.position); 
        animator.SetFloat("distancia", distancia);
    }
}