using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrelas : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float velocity;
    private Contador contador;
    private Rigidbody2D rg2D;
    private float rate;
    [SerializeField] private GameObject estrelaPrefab;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        rg2D = GetComponent<Rigidbody2D>();
        rg2D.gravityScale = 0f;
        rate = 5f;
        contador = new Contador(rate);
        Debug.Log(transform.parent.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < 50)
        {
            rg2D.gravityScale = 1f;
           
         //   Destroy(gameObject, 7f);
        }
        else
        {
            rg2D.gravityScale = 0f;
        } 
        Multiplicar();
    }

    void Multiplicar()
    {
        if (contador.RepeatCountTime())
        {
            Debug.Log(transform.parent.transform.position);
            GameObject star = Instantiate(estrelaPrefab, transform.parent);
            star.transform.position = transform.parent.position;
        }

        
    }
}
