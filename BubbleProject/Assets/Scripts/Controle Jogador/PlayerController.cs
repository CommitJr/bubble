using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region SCOPE
    private Collider2D colliderTouch;
    private GameObject wavePropagation;
    #endregion

    #region START
    void Start()
    {
        colliderTouch = GetComponent<Collider2D>();
        wavePropagation = GameObject.FindWithTag("WavePropagation");
    }
    #endregion

    #region UPDATE
    void Update()
    {
        ControllerTouch();
    }
    #endregion

    #region TOUCH CONTROLLER
    private void ControllerTouch()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            TouchKeyDown();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            TouchKeyUp();
        }
    }

    private void TouchKeyDown()
    {
        Vector3 ponto = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
        Vector3 pontoZ = new Vector3(ponto.x, ponto.y, wavePropagation.transform.position.z);
        transform.position = pontoZ;

        colliderTouch.enabled = true;
    }

    private void TouchKeyUp()
    {
        colliderTouch.enabled = false;
    }
    #endregion
}
