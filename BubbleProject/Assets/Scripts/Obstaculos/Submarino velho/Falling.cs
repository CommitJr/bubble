using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
          direction = (player.transform.position - transform.position);
          if (direction.magnitude < 20)
          {
                rb.gravityScale = 0.5f;
          }
    }
}
