using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecionaveis : MonoBehaviour
{
    private PlayerController playerController;
    private int metros;
    private GameObject player;
    private GameObject nexus;

    void Start()
    {
        metros = 0;
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
        player = GameObject.FindWithTag("BolhaRastreio");
        nexus = GameObject.FindWithTag("Nexus");
    }

    // Update is called once per frame
    void Update()
    {
        metros = ((int)Vector3.Distance(player.transform.position, nexus.transform.position));
        
        if (metros < 3)
        {
            Debug.Log("colecionavel coletado");
            if (playerController.GetHealth() < 3)
            {
                playerController.SetHealth(playerController.GetHealth() + 1);
                nexus.SetActive(false);
            }

        }
    }
}
