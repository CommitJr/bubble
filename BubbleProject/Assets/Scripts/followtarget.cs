using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtarget : MonoBehaviour
{
    private Vector2 direction;
    private GameObject player;
    [SerializeField] private float velocity;
    private float angle;
    private Rigidbody2D rg2D;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.transform.position - transform.position);
        Debug.Log(direction.magnitude);
        if (direction.magnitude < 10)
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
