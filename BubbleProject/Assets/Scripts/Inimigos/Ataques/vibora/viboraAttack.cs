using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viboraAttack : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade;
    private int direcao = -1;
    [Header("Componentes")]
    public Rigidbody2D inimigoRb;

    private void FixedUpdate()
    {
        Move();
        InvokeRepeating("Attack",1.5f, 5f);
    }
    private void Move()
    {
        inimigoRb.velocity = new Vector2(velocidade * direcao, inimigoRb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D parede)
    {
        if (parede.transform.tag == "parede" || parede.transform.tag == "Pedras")
        {
            direcao *= -1;
            transform.eulerAngles = new Vector2(0f, 180);
            if (direcao == -1)
            {
                transform.eulerAngles = new Vector2(0f, 0);
            }
        }
    }
    void Attack() {
        if (velocidade == 2)
        {
            velocidade = velocidade * 10;
        }
        else
        {
            velocidade = velocidade / 10;
        }
    }
}
