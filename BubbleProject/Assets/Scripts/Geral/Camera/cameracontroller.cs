using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject bolha;
    public GameObject cameraPositionAtual;

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraNovaPosition = cameraPositionAtual.transform.position;

        cameraNovaPosition.y = bolha.transform.position.y;

        cameraPositionAtual.transform.position = cameraNovaPosition;
    }
}
