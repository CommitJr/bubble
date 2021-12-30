using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtarget : MonoBehaviour
{
    private Vector2 direction;
    private Transform player;
    [SerializeField] private Transform centro;
    [SerializeField] private float velocity;
    private float angle;
    private Rigidbody2D rg2D;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("BolhaRastreio");
        if (playerObject)
        {
            player = playerObject.GetComponent<Transform>();
        }
        
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            direction = (player.position - centro.position);

            if (Vector2.Distance(centro.position, player.position) < 20)
            {
                direction = direction.normalized;
                direction *= velocity;
                angle = Vector2.SignedAngle(Vector2.up, direction);
                transform.rotation = Quaternion.Euler(0, 0, angle);
                rg2D.velocity = direction;
            }
            else
            {
                rg2D.velocity = Vector2.zero;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "BolhaRastreio")
        {
            rg2D.simulated = false;
            this.GetComponent<followtarget>().enabled = false;
        }
    }
}
