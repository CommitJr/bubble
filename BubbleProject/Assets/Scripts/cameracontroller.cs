using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{

    public GameObject personagem;
    public GameObject cameraPositionAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraNovaPosition = cameraPositionAtual.transform.position;

        cameraNovaPosition.y = personagem.transform.position.y;

        cameraPositionAtual.transform.position = cameraNovaPosition;

    }
}
