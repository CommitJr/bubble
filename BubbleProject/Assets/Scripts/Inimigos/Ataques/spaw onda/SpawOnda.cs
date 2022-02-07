
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOnda : MonoBehaviour
{
    private ParticleSystem part;
    private AudioSource fartSound ;
    private Contador contador;
    [SerializeField] private int temporizador;
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();

        part = GetComponent<ParticleSystem>();
        fartSound = GetComponent<AudioSource>();

        contador = new Contador(temporizador);
        part.Stop();
        fartSound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.FindPlayer(this.transform, 10))
        {
            if (contador.RepeatCountTime())
            {
                CriaOnda();
            }

        }
    }

    private void CriaOnda()
    {
        Debug.Log("pum");
        part.Play();
        fartSound.Play();
    }
}
