using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubaraoAttack : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade;
    private int direcao = -1;
    [Header("Componentes")]
    public Rigidbody2D inimigoRb;
    private float initialSpeed;

    private void Start()
    {
        initialSpeed = velocidade;
    }
    private void FixedUpdate()
    {
        Move();
        InvokeRepeating("Attack", 1.5f, 5f);
    }
    private void Move()
    {
        inimigoRb.velocity = new Vector2(velocidade * direcao, inimigoRb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D parede)
    {
        if (parede.transform.tag == "parede")
        {
            Debug.Log("Aqui " + gameObject.name);
            direcao *= -1;
            transform.eulerAngles = new Vector2(0f, 180);
            if (direcao == -1)
            {
                transform.eulerAngles = new Vector2(0f, 0);
            }
            foreach (var c in gameObject.GetComponentsInChildren<PolygonCollider2D>())
            {
                c.enabled = false;
            }
            //StartCoroutine(EnableCollision(2f));
            if (velocidade == initialSpeed)
            {
                transform.position = new Vector2(transform.position.x + (5 * direcao), transform.position.y);
                StartCoroutine(EnableCollision(0));
            }
            else
                StartCoroutine(EnableCollision(0.2f));

        }
    }

    void Attack()
    {
        if (velocidade == initialSpeed)
        {
            velocidade = velocidade * 10;
        }
        else
        {
            velocidade = velocidade / 10;
        }
    }

    private IEnumerator EnableCollision(float delay)
    {
        yield return new WaitForSeconds(delay);
        foreach (var c in gameObject.GetComponentsInChildren<PolygonCollider2D>())
        {
            c.enabled = true;
        }
    }

}
