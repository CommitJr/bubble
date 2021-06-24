using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinudalMoviment : MonoBehaviour
{
    [Header("Movimento")]
    private int direcao = -1;
    public float speed;

    public float amplitude;
    [Header("Componentes")]
    public Rigidbody2D inimigoRb;
    

    float startingVal;

    void Start()
    {
        startingVal = transform.position.y;
    }
    
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        Move();
        Sine(speed, amplitude);
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


    void Sine(float Speed, float Amplitude)
    {
        float x = transform.position.x;
        float z = transform.position.z;
        float y = Mathf.Sin(Time.time * Speed) * Amplitude;

        transform.position = new Vector3(x, startingVal + y, z);
    }
}
