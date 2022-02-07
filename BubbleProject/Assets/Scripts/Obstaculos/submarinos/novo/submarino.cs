using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submarino : MonoBehaviour
{
    public GameObject torpedo;
    private Transform player;
    private PlayerController playerController;

    private sinusoidalMoviment sinu;
    [SerializeField] private float rate;
    private float next;

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

        next = Time.time;
        sinu = GetComponent<sinusoidalMoviment>();
        sinu.enabled = false;
    }
    void Update()
    {
        if (playerController.FindPlayer(this.transform, 10))
        {
            sinu.enabled = true;
            Fogo();
        }
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
