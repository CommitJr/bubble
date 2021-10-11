using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonFire : MonoBehaviour
{
    private ParticleSystem part;
    private Vector2 direction;
    private Transform player;
    [SerializeField] private Transform centro;


    void Start()
    {
        ParticleSystem part = GetComponent<ParticleSystem>();
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.position - centro.position);

        if (Vector2.Distance(centro.position, player.position) < 10)
        {
            part.Play();
        }
        else
        {
            part.Stop();
        }
    }
}
