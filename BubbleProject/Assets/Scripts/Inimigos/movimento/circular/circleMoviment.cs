using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleMoviment : MonoBehaviour
{
    [Header("Movimento")]
    private int direcao = -1;
    public float speed;

    [Header("Componentes")]
    public Rigidbody2D inimigoRb;

    float startingValy, startingValx;

    void Start()
    {
        startingValy = transform.position.y;
        startingValx = transform.position.x;
    }

    private void FixedUpdate()
    {
        Move();
        Circle(speed);
    }
    private void Move()
    {
        inimigoRb.velocity = new Vector2(speed * direcao, inimigoRb.velocity.y);
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

    void Circle(float Speed)
    {
        float x = Mathf.Cos(Time.time * Speed);
        float z = 0;
        float y = Mathf.Sin(Time.time * Speed);

        transform.position = new Vector3(startingValx + x, startingValy + y, z);
    }
}
