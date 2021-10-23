using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region SCOPE
    private Collider2D colliderTouch;
    private GameObject wavePropagation;
    #endregion

    #region START
    void Start()
    {
        DefineStart();
    }

    private void DefineStart()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            colliderTouch = GetComponent<Collider2D>();
            wavePropagation = GameObject.FindWithTag("WavePropagation");
        }
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
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            ControllerTouchInGame();
        }
        else
        {
            ControllerTouchInMenu();
        }
    }

    private void ControllerTouchInGame()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            TouchKeyDown();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            TouchKeyUp();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TouchEscapeGame();
        }
    }

    private void ControllerTouchInMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TouchEscapeMenu();
        }
    }

    private void TouchEscapeMenu()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            GetComponent<GeneralFunctions>().GoToExit();
        }
        else
        {
            GetComponent<GeneralFunctions>().GoToMenu();
        }
    }

    private void TouchEscapeGame()
    {
        GetComponent<GeneralFunctions>().PauseController();
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
