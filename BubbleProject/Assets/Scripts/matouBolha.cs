using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matouBolha : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject tcena;
    trocacena scripttcena;

    void Start(){
        scripttcena = tcena.GetComponent<trocacena>();       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {   

        if (collision.gameObject.tag == "Player") {

            scripttcena.IniciaTransicao(0);
            scripttcena.MudaCena();

        }

    }
}
