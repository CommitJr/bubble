using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torpedo : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    Rigidbody2D rb;
    Vector2 diretion;

    [SerializeField] private GameObject alvo;
 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Invoke("liberacao", 2f);

        Destroy(gameObject, 10f);
    }



    void liberacao()
    {
        rb.gravityScale = 0f;
        diretion = (alvo.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(diretion.x, diretion.y);
    }
}
