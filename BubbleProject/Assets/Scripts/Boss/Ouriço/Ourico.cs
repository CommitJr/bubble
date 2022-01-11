using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ourico : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] espinhos;
    private Transform playerPosition;
    private Contador contador;
    [SerializeField] private float timerForSpawn;

    void Start()
    {
        contador = new Contador(timerForSpawn);
    }

    void Update()
    {
        
    }

    // faz os espinhos se soltarem e irem atrás do player
    private void SendThorn()
    {
        if (contador.RepeatCountTime())
        {
            espinhos[Random.Range(0, 51)].transform.position = new Vector3 (playerPosition.transform.position.x, playerPosition.transform.position.y, 0);
        }
    }

    // faz os espinhos lançados nascerem de novo
    private void SendThornBack()
    {
        if (contador.RepeatCountTime())
        {
            espinhos[Random.Range(0, 51)].transform.position = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y, 0);
        }
    }
}
