using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletricalAttack : MonoBehaviour
{
   
    private ParticleSystem part;
    private PlayerController playerController;
    private List<ParticleCollisionEvent> collisionEvents;
    private AudioSource eletrical;

    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent< PlayerController>();
        eletrical = GetComponent<AudioSource>();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        { 
            playerController.enabled = false;
            Debug.Log( playerController.enabled); 
            eletrical.Play();
            Invoke("choque", 3f);
        }
    }

    
    void choque()
    {
        playerController.enabled = true;
    }
}
