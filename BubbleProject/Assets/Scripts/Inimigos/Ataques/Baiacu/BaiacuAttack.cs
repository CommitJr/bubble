using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiacuAttack : MonoBehaviour
{
    [SerializeField] private GameObject inchado;
    [SerializeField] private GameObject normal;
    private int direcao = -1;
    public float velocidadeNormal;
    public float velocidadeInchado;
    private PlayerController playerController;
    private AudioSource baiacuSound;

    void Start()
    {
        baiacuSound = GetComponent<AudioSource>();
        baiacuSound.Stop();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

    }
    void Update()
    {
        Move();
        Infla();
    }

    void Move()
    {
        if (inchado.activeSelf == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeInchado * direcao, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeNormal * direcao, GetComponent<Rigidbody2D>().velocity.y);
        } 
    }

    private void Infla()
    {
        if (playerController.FindPlayer(this.transform, 5))
        {
            baiacuSound.Play();
            inchado.SetActive(true);
            normal.SetActive(false);
            GetComponent<PolygonCollider2D>().enabled = false;
        }
        else
        {
            Attack();
        }
    }

    void OnCollisionEnter2D(Collision2D objeto)
    {
        if (objeto.transform.tag == "Player" && transform.tag == "Baiacu")
        {
            playerController.KillPlayer();
        }

        if (objeto.transform.tag == "parede" || objeto.transform.tag == "Pedras")
        {
            direcao *= -1;
            
            transform.eulerAngles = new Vector2(0f, 180);
            if (direcao == -1)
            {
                transform.eulerAngles = new Vector2(0f, 0);
            }
        }
    }

    void Attack()
    {
        inchado.SetActive(false);
        normal.SetActive(true);
        GetComponent<PolygonCollider2D>().enabled = true;
    }
}
