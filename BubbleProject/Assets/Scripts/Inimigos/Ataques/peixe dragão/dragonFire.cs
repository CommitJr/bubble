using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonFire : MonoBehaviour
{
    private ParticleSystem part;
    private Transform player;
    [SerializeField] private Transform centro;


    void Start()
    {
        part = GetComponent<ParticleSystem>();
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        part.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(centro.position, player.position) < 3)
        {
            Debug.Log("aaa");
            part.Play();
        }
        else
        {
            part.Stop();
        }
    }
}
