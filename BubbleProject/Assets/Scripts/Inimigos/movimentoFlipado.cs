using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoFlipado : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade;
    private int direcao = -1;
    [Header("Componentes")]
    public Rigidbody2D inimigoRb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        inimigoRb.velocity = new Vector2(velocidade * direcao, inimigoRb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D parede)
    {
        if (parede.transform.tag == "parede")
        {
            direcao *= -1;
            transform.eulerAngles = new Vector2(0f, 0);
            if(direcao == -1)
            {
                transform.eulerAngles = new Vector2(0f, 180);
            }
        }
    }
}
