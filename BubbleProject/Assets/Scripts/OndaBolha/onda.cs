using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* isso aqui vai criar o GameObject associado ao clicar com o lado esquerdo 
 *  do mouse*/

public class onda : MonoBehaviour
{
    private Collider2D colisor;
    public GameObject wavePropagation;
    void Start()
    {
        colisor = GetComponent<Collider2D>();
    }

  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)){
            
            Vector3 ponto = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            Vector3 pontoZ = new Vector3(ponto.x, ponto.y, wavePropagation.transform.position.z);
            transform.position = pontoZ;
            
            colisor.enabled = true;

        }
        if (Input.GetKeyUp(KeyCode.Mouse0)){
            colisor.enabled = false;

        }
    }


}