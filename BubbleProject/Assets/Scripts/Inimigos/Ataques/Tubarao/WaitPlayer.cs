using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitPlayer : MonoBehaviour
{
    private Transform player;
    [SerializeField] private Transform centro;
    private tubaraoAttack attackScript;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        attackScript = gameObject.GetComponent<tubaraoAttack>();
    }
    void Update()
    {
        if (Vector2.Distance(centro.position, player.position) < 5)
        {
            attackScript.enabled = true;
        }
        else
        {
            attackScript.enabled = false;
        }
    }
}
