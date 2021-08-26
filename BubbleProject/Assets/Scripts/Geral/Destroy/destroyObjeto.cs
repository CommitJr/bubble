using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjeto : MonoBehaviour
{
    [SerializeField] private float temporizador;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Aguarde());
    }

    IEnumerator Aguarde(){
        yield return new WaitForSeconds(temporizador);
        Destroy(gameObject);
    }
}