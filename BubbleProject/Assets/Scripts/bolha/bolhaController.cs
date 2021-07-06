
//using System.Numerics;
//using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bolhaController : MonoBehaviour
{
    private Vector3 swipeDirection;
    [SerializeField] private int forca = 120;
    [SerializeField] private Collider2D colisorMouse;
    [SerializeField] private float velocidadeLimite = 2.5f;
    [SerializeField] private Animator animator;

    void start()
    {
        animator = GetComponent<Animator>();
    }
    
    void FixedUpdate(){
        // swipeDirection = new Vector3(colisorMouse.transform.position.y, colisorMouse.transform.position.x, colisorMouse.transform.position.z);
        //swipeDirection.Normalize();
        if (GetComponent<Rigidbody2D>().velocity.x > velocidadeLimite){
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeLimite, GetComponent<Rigidbody2D>().velocity.y);
           

        }
        if (GetComponent<Rigidbody2D>().velocity.y > velocidadeLimite){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, velocidadeLimite);
    
        }
        if (GetComponent<Rigidbody2D>().velocity.x < -velocidadeLimite){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadeLimite, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (GetComponent<Rigidbody2D>().velocity.y < -velocidadeLimite){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -velocidadeLimite);
        }
    }

    void OnTriggerEnter2D(Collider2D objetoQualquer){
        if(objetoQualquer.gameObject.CompareTag("wave")){

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = new Vector2(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y).normalized;
            
                
            if (direction.x > 0)
            {
                animator.SetBool("Toque x", true);
                animator.SetBool("Toque y", false);
            }
            if (direction.x < 0)
            {
                animator.SetBool("Toque y", true);
                animator.SetBool("Toque x", false);
            }

               


            GetComponent<Rigidbody2D>().AddForce(direction * forca);
        }
    }
    public void DisableToque()
    {
        animator.SetBool("Toque y", false);
        animator.SetBool("Toque x", false);
    }
}
