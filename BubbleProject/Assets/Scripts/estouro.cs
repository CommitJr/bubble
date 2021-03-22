using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estouro : MonoBehaviour
{


    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D bateu)    // eventos de colisões
    {
        if (bateu.transform.tag == "Bolha")        // galho da arvore
        {
            print("bolha estourou");
            // animação de estouro;
        }
    }
}