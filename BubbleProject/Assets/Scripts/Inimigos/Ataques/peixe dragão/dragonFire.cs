using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonFire : MonoBehaviour
{
    private ParticleSystem part;
    private Transform player;
    [SerializeField] private Transform centro;
    private PlayerController playerController;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

        part.Stop();

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Vector2.Distance(centro.position, player.position));
        if (Vector2.Distance(centro.position, player.position) < 5)
        {
       
            part.Play();
        //    Debug.Log("FOGO");

            
        }
        else
        {
            if (!part.isPlaying)
            {
                part.Stop();
            }
        }
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.tag);
        //  int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        if (other.tag == "Player")
        {    
           
            KillPlayer();
        }
    }

    public void KillPlayer()
    {

        playerController.GetComponent<PlayerController>().SetHealth(0);
    }

}
