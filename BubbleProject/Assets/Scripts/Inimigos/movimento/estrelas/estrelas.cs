using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrelas : MonoBehaviour
{
    private Vector2 direction;
    private Transform player;
    [SerializeField] private float velocity;
    private float angle;
    private Rigidbody2D rg2D;

    [SerializeField] private float rate;
    private float next;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        rg2D = GetComponent<Rigidbody2D>();
        rg2D.gravityScale = 0f;

        rate = 5f;
        next = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < 50)
        {
            rg2D.gravityScale = 1f;
            
        }
        else
        {
            rg2D.gravityScale = 0f;
        }
        
        /*
        Multiplicar();
        Destroy(gameObject, 5f);
        */   
    }

    void Multiplicar()
    {
        if (Time.time > next)
        {
            Instantiate(this);
            next = Time.time + rate;
        }

        
    }
}
