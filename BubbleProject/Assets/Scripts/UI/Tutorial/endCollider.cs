using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCollider : MonoBehaviour
{
    [SerializeField] GameObject tutorial;
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tutorial.SetActive(false);
        }
    }
}
