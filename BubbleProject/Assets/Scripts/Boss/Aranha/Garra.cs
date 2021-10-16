using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garra : MonoBehaviour
{
    [SerializeField] private animatorControll boss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BolhaRastreio")
        {
            collision.transform.SetParent(transform.GetChild(0));
            collision.transform.localPosition = Vector2.zero;
            boss.GetComponent<Animator>().SetBool("End", true);
        }
    }
}
