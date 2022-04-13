using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade;
    [SerializeField] private int direcao = -1; // -1 -> Esquerda / 1 -> Direita
   
    [Header("Componentes")]
    public Rigidbody2D inimigoRb;

    
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        inimigoRb.velocity = new Vector2(velocidade * direcao, inimigoRb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "parede" || collision.collider.gameObject.tag == "Pedras")
        {
            direcao *= -1;
            transform.eulerAngles = new Vector2(0f, 180);
            if(direcao == -1)
            {
                transform.eulerAngles = new Vector2(0f, 0);
                gameObject.transform.position = new Vector2(gameObject.transform.position.x - 1, gameObject.transform.position.y);
            }
        }
    }
}
