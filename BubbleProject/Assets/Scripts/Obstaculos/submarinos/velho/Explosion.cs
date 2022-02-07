using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float delay = 1f;
    public GameObject exp;
    public float radius = 1f;
    private AudioSource explosionSound;


    void Start()
    {
        explosionSound = GetComponent<AudioSource>();
        explosionSound.Stop();
    }

    void Explode()
    {
        Instantiate(exp, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(700f, transform.position, radius); 
            }
        }
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
        explosionSound.Play();
    }
}

