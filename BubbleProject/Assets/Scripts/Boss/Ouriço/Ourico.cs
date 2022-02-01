using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ourico : MonoBehaviour
{
    #region SCOPE
    [Header("Find closest Thorn")]
    GameObject[] allThorns;
    private Transform playerPosition;
    GameObject closestThorn = null;

    [Header("Thorn Settings")]
    private Transform[] oldPosition;
    private int index;

    [Header("Thorn Moviment Atributtes")]
    private Contador spaw;
    [SerializeField] private float timerForSpawn;
    [SerializeField] private float fadeSpeed;
    [SerializeField] private float force;
    [SerializeField] private Transform centro;
    [SerializeField] private float distanceOurico;
    [SerializeField] private float distanceThorn;

    #endregion
    void Start()
    {
        spaw = new Contador(timerForSpawn);
        spaw.SetCurrentTime(timerForSpawn);

        playerPosition = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

        allThorns = GameObject.FindGameObjectsWithTag("Espinhos");
        oldPosition = new Transform[15];

        for(int i = 0; i < allThorns.Length; i++)
        {
            oldPosition[i] = allThorns[i].GetComponent<Transform>();
        }
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
        }
    }



    #endregion

    #region Find nearby
    void FindClosestThorn()
    {
        float distanceToClosestThorn = Mathf.Infinity;

        int indice = 0;

        foreach (GameObject currentThorn in allThorns)
        {
            float distanceToPlayer = (playerPosition.transform.position - currentThorn.transform.position).sqrMagnitude;
            if (distanceToPlayer < distanceToClosestThorn)
            {
                distanceToClosestThorn = distanceToPlayer;
                closestThorn = currentThorn;

                index = indice;
            }
            indice++;
        }
    }
    #endregion

    #region Change alpha
    private IEnumerator FadeOut()
    {
        while (closestThorn.GetComponentInChildren<SpriteRenderer>().color.a > 0)
        {
            Color objectColor = closestThorn.GetComponentInChildren<SpriteRenderer>().color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            closestThorn.GetComponentInChildren<SpriteRenderer>().color = objectColor;


            yield return null;
        }
    }


    #endregion
    #endregion

}
