
//using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bolhaController : MonoBehaviour
{
    private Vector3 swipeDirection;
    private int velocidade = 100;
    [SerializeField] private Collider2D colisorMouse;

    
    void Update(){
        colisorMouse = GetComponent<Collider2D>();
        swipeDirection = new Vector3(-colisorMouse.transform.position.x, -colisorMouse.transform.position.y, -colisorMouse.transform.position.z);
        swipeDirection.Normalize();
    }

    void OnTriggerEnter2D(Collider2D objetoQualquer){
        if(objetoQualquer.gameObject.CompareTag("wave"))
            GetComponent<Rigidbody2D>().AddForce(swipeDirection * velocidade);
    }
}
