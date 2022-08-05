using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetes : MonoBehaviour
{
    private ParticleSystem part;
    private PlayerController playerController;
    [SerializeField] private Transform centro;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>(); 
        part.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.FindPlayer(centro, 3))
        {
            part.Play();

        }
        else
        {
            if (!part.isPlaying)
            {
                part.Stop();
            }
        }
    }
}
