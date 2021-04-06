
//using System.Numerics;
//using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bolhaController : MonoBehaviour
{
    private Vector3 swipeDirection;
    [SerializeField] private int velocidade = 100;
    [SerializeField] private Collider2D colisorMouse;
    [SerializeField] private float velocity;
    
    void FixedUpdate(){
        // swipeDirection = new Vector3(colisorMouse.transform.position.y, colisorMouse.transform.position.x, colisorMouse.transform.position.z);
        //swipeDirection.Normalize();
        if (GetComponent<Rigidbody2D>().velocity.x > velocity)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (GetComponent<Rigidbody2D>().velocity.y > velocity)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,velocity);
        }
        if (GetComponent<Rigidbody2D>().velocity.x < -velocity)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocity, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (GetComponent<Rigidbody2D>().velocity.y < -velocity)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -velocity);
        }
    }

    void OnTriggerEnter2D(Collider2D objetoQualquer){
        if(objetoQualquer.gameObject.CompareTag("wave")){

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //GetComponent<Rigidbody2D>().AddForce(-objetoQualquer.GetComponent<Rigidbody>().velocity.normalized * velocidade);
            //GetComponent<Rigidbody2D>().AddForce(-transform.TransformDirection(colisorMouse.transform.position).normalized * velocidade);
            
            Vector2 direction = new Vector2(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y).normalized;

            GetComponent<Rigidbody2D>().AddForce(direction * velocidade);
        }
    }
}
