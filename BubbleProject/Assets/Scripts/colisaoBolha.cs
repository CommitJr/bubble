
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoBolha : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private Collider2D colisorMaior;

    void Start(){
        colisorMaior = GetComponent<Collider2D>();
    }

    void Update(){
    }

    /*

    void OnTriggerEnter2D(Collider2D obstaculo){
        if(obstaculo.gameObject.CompareTag("inimigo"))
            Debug.Log("bolha estourou");

    }*/
}
