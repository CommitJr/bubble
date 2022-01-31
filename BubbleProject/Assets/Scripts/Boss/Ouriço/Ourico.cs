using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ourico : MonoBehaviour
{
    [Header("Find closest Thorn")]
    GameObject[] allThorns;
    private Transform playerPosition;
    GameObject closestThorn;

    [Header("Thorn Settings")]
    SpriteRenderer color;
    int thorn, contador;
    Vector2 oldPosition;

    [Header("Thorn Moviment Atributtes")]
    private Contador spaw;
    [SerializeField] private float timerForSpawn;
    private Contador respaw;
    [SerializeField] private float timerForReSpawn;
    double alphaAtributte = 1;
    [SerializeField] private float force;
    [SerializeField] private Transform centro;
    void Start()
    {
        spaw = new Contador(timerForSpawn);
        respaw = new Contador(timerForReSpawn);

        playerPosition = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

        allThorns = GameObject.FindGameObjectsWithTag("Espinhos"); // gamesObjects com a tag espinhos
    }

    void Update()
    {
        if (Vector2.Distance(centro.position, playerPosition.position) < 16)
        {
            FindClosestThorn();
            Call();
        }
    }

    private void Call()
    {
        if (spaw.RepeatCountTime())
        {
            SendThorn();
        }

        if (respaw.RepeatCountTime())
        {
            SendThornBack();
        }
    }

    // faz os espinhos se soltarem e irem atrás do player
    private void SendThorn()
    {
        closestThorn.GetComponent<Rigidbody2D>().AddForce(closestThorn.transform.right*force, ForceMode2D.Impulse);

        if (Vector2.Distance(centro.position, closestThorn.transform.position) > 15)
        {
            if (alphaAtributte != 0)
            {
                alphaAtributte = alphaAtributte - 0.5f;
            }

            color.color = new Color(1, 1, 1, (float)alphaAtributte);
            closestThorn.GetComponentInChildren<PolygonCollider2D>().enabled = false;
        }
    }

    // faz os espinhos lançados nascerem de novo
    private void SendThornBack()
    {
        closestThorn.transform.position = oldPosition;

        if (alphaAtributte != 1)
        {
            alphaAtributte = alphaAtributte + 0.5f;
        }

        color.color = new Color(1, 1, 1, (float)alphaAtributte);
        closestThorn.GetComponentInChildren<PolygonCollider2D>().enabled = true;

    }

    void FindClosestThorn()
    {
        float distanceToClosestThorn = Mathf.Infinity;
        
        foreach (GameObject currentThorn in allThorns)
        {
            float distanceToPlayer = (playerPosition.transform.position - currentThorn.transform.position).sqrMagnitude;
            if (distanceToPlayer < distanceToClosestThorn)
            {
                distanceToClosestThorn = distanceToPlayer;
                closestThorn = currentThorn;

                oldPosition = currentThorn.transform.position;
                color = currentThorn.GetComponentInChildren<SpriteRenderer>();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Player")
        {
            closestThorn.SetActive(false);
        }
    }
}
