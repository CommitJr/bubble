using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grito : MonoBehaviour
{
    [SerializeField] private GameObject ondaPrefab;
    [SerializeField] private Transform spawnPosition;
    private Contador contador;
    private PlayerController playerController;
    private AudioSource screamSound;


    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
        screamSound = GetComponent<AudioSource>();

        contador = new Contador(3);
        screamSound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.FindPlayer(this.transform, 10))
        {
            if (contador.RepeatCountTime())
            {
                CriaOnda();
                screamSound.Play();
            }
        }
    }
    private void CriaOnda(){
        Instantiate(ondaPrefab, spawnPosition.position, Quaternion.identity);
    }
}
