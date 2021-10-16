using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private animatorControll boss;


   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(boss.GetEnableWave() && collision.tag == "BolhaRastreio")
        {
            collision.transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce( direction );
            boss.SetEnableWave(false);
            Debug.Log("bateu");
        }
    }
}
