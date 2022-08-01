using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonFire : MonoBehaviour
{
    private ParticleSystem part;
    private Transform player;
    [SerializeField] private Transform centro;
    private PlayerController playerController;
    private AudioSource dragonSound;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

        dragonSound = GetComponent<AudioSource>();
        dragonSound.Stop();

        part.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Vector2.Distance(centro.position, player.position));
        if (playerController.FindPlayer(centro, 7))
        {
            Debug.Log("player");
            part.Play();
            dragonSound.Play();

        }
        else
        {
            if (!part.isPlaying)
            {
                part.Stop();
                dragonSound.Stop();
            }
        }
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("ATAQUE ELETRICO");
            playerController.KillPlayer();
        }
    }
}
