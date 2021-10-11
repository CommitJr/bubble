using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lula : MonoBehaviour
{
    public GameObject oleo;
    [SerializeField] private float speed = 300;
    private Transform player;
    private float dirX, dirY;

    [SerializeField] private float rate;
    private float next;

    void Start()
    {
        next = Time.time;
    }
    void Update()
    {
        Fogo();
    }

    void Fogo()
    {
        if (Time.time > next)
        {
            Debug.Log(transform.position);
            Instantiate(oleo, transform.position, Quaternion.identity);
            next = Time.time + rate;
        }
    }
}
