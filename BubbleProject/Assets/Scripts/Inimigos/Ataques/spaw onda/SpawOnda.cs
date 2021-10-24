
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOnda : MonoBehaviour
{
    private ParticleSystem part;
    private Contador contador;
    [SerializeField] private int temporizador;
    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        contador = new Contador(temporizador);
        part.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        if (contador.RepeatCountTime() )
        {
            CriaOnda();
        }
     
    }

    private void CriaOnda()
    {
        Debug.Log("pum");
        part.Play();
    }
}
