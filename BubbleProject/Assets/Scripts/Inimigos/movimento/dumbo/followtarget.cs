using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtarget : MonoBehaviour
{
    private Vector2 direction;
    private Transform player;
    [SerializeField] private float velocity;
    private float angle;
    private Rigidbody2D rg2D;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Colisor Interno").GetComponent<Transform>();
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.position - transform.position);

        if ( Vector2.Distance(transform.position, player.position) < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, velocity * Time.deltaTime);

            direction = direction;
            direction *= velocity;
            angle = Vector2.SignedAngle(Vector2.up, direction);
            transform.rotation = Quaternion.Euler(0, 0, angle);
            Debug.Log("diretion" + direction);
            Debug.Log("angle" + angle);
        }
        
        else
        {
            rg2D.velocity = Vector2.zero;
        }

       
    }
}
