using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoArpao : MonoBehaviour
{
    #region SCOPE
    [Header("Movimento")]
    [SerializeField] private float velocidade;
    private int direcao;
    #endregion

    #region UPDATE
    private void FixedUpdate()
    {
        Move();
    }
    #endregion

    #region METHODS
    private void Move()
    {
        if (gameObject.GetComponent<Transform>().rotation.y == 0)
        {
            direcao = -1;
        }

        if (gameObject.GetComponent<Transform>().rotation.y != 0)
        {
            direcao = 1;
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade * direcao, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }
    #endregion

    #region COLLISION
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "parede" || collision.collider.gameObject.tag == "Pedras")
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
