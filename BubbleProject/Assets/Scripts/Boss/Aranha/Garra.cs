using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garra : MonoBehaviour
{
    [SerializeField] private animatorControll boss;
    private onda onda;

    private void Start()
    {
        onda = GameObject.FindGameObjectWithTag("wave").GetComponent<onda>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BolhaRastreio")
        {
            Debug.Log(collision.tag);
            onda.enabled = false;
            collision.gameObject.GetComponent<bolhaController>().enabled = false;
            collision.transform.parent.SetParent(transform.GetChild(0));
            collision.transform.localPosition = Vector2.zero;
            boss.GetComponent<Animator>().SetBool("End", true);
        }
    }
}
