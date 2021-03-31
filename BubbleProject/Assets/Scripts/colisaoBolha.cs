
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoBolha : MonoBehaviour
{
    // Start is called before the first frame update



    void Start(){
        
    }

    void Update(){


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            print("bolha estourou");
        }
    }
}
