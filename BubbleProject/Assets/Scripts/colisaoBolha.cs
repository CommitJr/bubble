
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoBolha : MonoBehaviour
{
    // Start is called before the first frame update

    
    public GameObject tcena;
    trocacena scripttcena;

    void Start(){
        scripttcena = tcena.GetComponent<trocacena>();
    }

    void Update(){

        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "matabolha") {
            
            scripttcena.IniciaTransicao(0);
            scripttcena.MudaCena();

        }

        if(collision.gameObject.tag == "end"){

            scripttcena.IniciaTransicao(0);
            scripttcena.MudaCena();

        }
    }
}
