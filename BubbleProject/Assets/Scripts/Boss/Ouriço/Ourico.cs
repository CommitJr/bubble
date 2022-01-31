using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ourico : MonoBehaviour
{
    #region SCOPE
    [Header("Find closest Thorn")]
    GameObject[] allThorns;
    private Transform playerPosition;
    GameObject closestThorn;

    [Header("Thorn Settings")]
    SpriteRenderer color;
    Vector2 oldPosition;

    [Header("Thorn Moviment Atributtes")]
    private Contador spaw;
    [SerializeField] private float timerForSpawn;
    private Contador respaw;
    [SerializeField] private float timerForReSpawn;
    [SerializeField] private float fadeSpeed;
    [SerializeField] private float force;
    [SerializeField] private Transform centro;
    [SerializeField] private float distanceOurico;
    [SerializeField] private float distanceThorn;

    #endregion
    void Start()
    {
        spaw = new Contador(timerForSpawn);
        respaw = new Contador(timerForReSpawn);

        playerPosition = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

        allThorns = GameObject.FindGameObjectsWithTag("Espinhos");
    }

    void Update()
    {
        if (Vector2.Distance(centro.position, playerPosition.position) < distanceOurico)
        {
            FindClosestThorn();
            Call();
        }
    }

    #region FUNCTIONS

    #region Main Function
    private void Call()
    {
        if (spaw.RepeatCountTime())
        {
            SendThorn();
        }

    }
    #endregion

    #region Moviment
    private void SendThorn()
    {
        closestThorn.GetComponent<Rigidbody2D>().AddForce(closestThorn.transform.right * force, ForceMode2D.Impulse);

        if (Vector2.Distance(centro.position, closestThorn.transform.position) > distanceThorn)
        {
            StartCoroutine(FadeOut());
            closestThorn.GetComponentInChildren<PolygonCollider2D>().enabled = false;

            Invoke("SendThornBack", 7f);
        }
    }


    private void SendThornBack()
    {
        if (closestThorn.GetComponentInChildren<PolygonCollider2D>().enabled)
        {
            closestThorn.transform.position = oldPosition;
            closestThorn.GetComponentInChildren<PolygonCollider2D>().enabled = true;
        }
        StartCoroutine(FadeIn());
    }
    #endregion

    #region Find nearby
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

                oldPosition = closestThorn.transform.position;
            }
        }
    }
    #endregion

    #region Change alpha
    private IEnumerator FadeOut()
    {
        while (closestThorn.GetComponentInChildren<SpriteRenderer>().material.color.a > 0)
        {
            Color objectColor = closestThorn.GetComponentInChildren<SpriteRenderer>().material.color;
            float fadeAmount = objectColor.a -(fadeSpeed * Time.deltaTime);
            
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            closestThorn.GetComponentInChildren<SpriteRenderer>().material.color = objectColor;
            
            yield return null;
        }
    }

    private IEnumerator FadeIn()
    {
        while (closestThorn.GetComponentInChildren<SpriteRenderer>().material.color.a < 1)
        {
            Color objectColor = closestThorn.GetComponentInChildren<SpriteRenderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            closestThorn.GetComponentInChildren<SpriteRenderer>().material.color = objectColor;

            yield return null;
        }
    }
    #endregion
    #endregion

}
