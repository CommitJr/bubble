using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    
    [SerializeField] private float speed = 7f;
    Rigidbody2D rb;
    Vector2 diretion;

    [SerializeField] private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio");
        rb = GetComponent<Rigidbody2D>();

        diretion = (player.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(diretion.x, diretion.y);



        Destroy(gameObject, 5f);
                
    }

    
}
