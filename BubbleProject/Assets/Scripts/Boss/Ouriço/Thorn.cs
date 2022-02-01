using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorn : MonoBehaviour
{
    [SerializeField] private Transform centro;

    [Header("Thorn's Settings")]
    [SerializeField] private float fadeSpeed;

    [SerializeField] private float distanceThorn;
    private Vector2 oldPosition;

    void Start()
    {
        oldPosition = transform.position;
        distanceThorn = 20;
    }

    void Update()
    {
        SendThornBack();
    }

    private void SendThornBack()
    {
        if (Vector2.Distance(centro.position, transform.position) > distanceThorn)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = oldPosition;

            GetComponentInChildren<PolygonCollider2D>().enabled = true;
            StartCoroutine(FadeIn());
        }
    }

    private IEnumerator FadeIn()
    {   

        while (GetComponentInChildren<SpriteRenderer>().color.a < 1)
        {
            Color objectColor = GetComponentInChildren<SpriteRenderer>().color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            GetComponentInChildren<SpriteRenderer>().color = objectColor;

            

            yield return null;
        }
    }
}
