using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletricalAttack : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem system;
    private Vector2 direction;

    private int aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem system = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        aux = 1;         
    }
}
