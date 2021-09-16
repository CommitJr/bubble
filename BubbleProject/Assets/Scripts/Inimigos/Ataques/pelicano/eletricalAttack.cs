using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletricalAttack : MonoBehaviour
{
   
    private ParticleSystem part;
    private List<ParticleCollisionEvent> collisionEvents;

    private int aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    private void OnParticleCollision(GameObject other)
    {
      //  int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        if(other.tag == "Player")
            Debug.Log("bateu");
       
            
    }
}
