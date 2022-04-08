using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletricalAttack : MonoBehaviour
{
   
    private ParticleSystem part;
    private PlayerController wave;
    private List<ParticleCollisionEvent> collisionEvents;
    private AudioSource eletrical;

    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
        //wave = GameObject.FindGameObjectWithTag("PlayerController").GetComponent< PlayerController>();
        eletrical = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (part.isPlaying == true)
        {
            if(eletrical.isPlaying == false)
            {
                eletrical.Play();
            }
            
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        //  int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        if (other.tag == "Player")
        {
           
            //other
            wave.enabled = false;
            Debug.Log(wave.enabled);
            Invoke("choque", 3f);
        }
    }

    
    void choque()
    {
        wave.enabled = true;
    }
}
