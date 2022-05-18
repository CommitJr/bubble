using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForPlayer : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private GameObject peixe;
    [SerializeField] private Transform centro;
    [SerializeField] private int ray;
    private Component var;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
        
    }


    void Update()
    {
        if (playerController.FindPlayer(centro, ray))
        {
            //Debug.Log(Vector2.Distance(centro.position, GameObject.FindGameObjectWithTag("Player").transform.position));
            if (peixe.GetComponent<viboraAttack>() == true)
            {
                peixe.GetComponent<viboraAttack>().enabled = true;
            }
            if (peixe.GetComponent<movimentoFlipado>() == true)
            {
                peixe.GetComponent<movimentoFlipado>().enabled = true;
            }
            if (peixe.GetComponent<movimento>() == true)
            {
                peixe.GetComponent<movimento>().enabled = true;
            }

        }
        else
        {
            if (peixe.GetComponent<viboraAttack>() == true)
            {
                peixe.GetComponent<viboraAttack>().enabled = false;
            }
            if (peixe.GetComponent<movimentoFlipado>() == true)
            {
                peixe.GetComponent<movimentoFlipado>().enabled = false;
            }
            if (peixe.GetComponent<movimento>() == true)
            {
                peixe.GetComponent<movimento>().enabled = false;
            }
        }
    }
}
