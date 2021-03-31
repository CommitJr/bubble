using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    private Vector3 ponto;
    private Collider2D colisor;
    // Start is called before the first frame update
    void Start()
    {
        colisor = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            colisor.enabled = !colisor.enabled;
        
        }
      
    }
}
