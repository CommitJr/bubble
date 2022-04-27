using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForPlayer : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private GameObject script;
    [SerializeField] private Transform centro;
    [SerializeField] private int ray;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
    }


    void Update()
    {
        if (playerController.FindPlayer(centro, ray))
        {
            script.SetActive(true);
        }
        else
        {
            script.SetActive(false);
        }
    }
}
