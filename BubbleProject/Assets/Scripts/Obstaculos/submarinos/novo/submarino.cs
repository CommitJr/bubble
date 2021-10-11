using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submarino : MonoBehaviour
{
    public GameObject torpedo;
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
            Instantiate(torpedo, transform.position, Quaternion.identity);
            next = Time.time + rate;
        }
    }
}
