using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lula : MonoBehaviour
{
    public GameObject oleo;
    [SerializeField] private Transform player;
    private float dirX, dirY;

    [SerializeField] private float rate;
    private float next;

    [SerializeField] private Transform triggerPosition;
    [SerializeField] private Transform destination;
    [SerializeField] private Transform bossPosition;
    private bool canAttack = true;
    private bool hasMove = false;
    [SerializeField] private float time;
    [SerializeField] private Moviment move;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        next = Time.time;
        time = Time.deltaTime;
        audioSource.Play();
    }
    void Update()
    {
        if (canAttack)
        {
            Fogo();
        }
        else if (bossPosition.position.y + 2 <= destination.position.y )
        {
            bossPosition.position = Vector2.Lerp(bossPosition.position, destination.position, time);
            audioSource.Play();
            
        }
        else 
        {
            move.enabled = true;
            canAttack = true;
        }

        if(player.position.y > triggerPosition.position.y && !hasMove)
        {
            canAttack = false;
            move.enabled = false;
            hasMove = true;
        }
       
    }

    void Fogo()
    {
        if (Time.time > next)
        {
            Instantiate(oleo, transform.position, Quaternion.identity);
            next = Time.time + rate;
        }
    }
}
