using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletricalAttack : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem system;
    private Vector2 direction;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ParticleSystem system = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.transform.position - transform.position);
        if (direction.magnitude < 40)
        {
            system.Play();
        }
        else
        {
            system.Stop();
        }
        Debug.Log(direction.magnitude);
    }
}
