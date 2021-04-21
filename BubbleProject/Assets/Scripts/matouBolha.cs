using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matouBolha : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject tcena;
    trocacena scripttcena;
    [SerializeField] private Animator animator;

    void Start(){
        scripttcena = tcena.GetComponent<trocacena>();       
    }

    void Update(){
    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {   
     
        if (collision.gameObject.tag == "Player") {

            animator.SetTrigger("estoura");

            StartCoroutine(Aguarde());

        }  

    }

    IEnumerator Aguarde(){
        yield return new WaitForSeconds(3.0f);
        scripttcena.IniciaTransicao(0);
        scripttcena.MudaCena();

    }
}
