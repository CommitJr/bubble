using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region SCOPE
    private int health;
    private bool _isControlled;


    private Collider2D colliderTouch;
    private GameObject wavePropagation;

    private GeneralFunctions generalFunctions;
    private SaveData saveData;
    private WorldManager worldManager;
    private LevelManager levelManager;

    [SerializeField] private GameObject death;
    private Transform player;
    #endregion

    #region START
    void Start()
    {
        DefineStart();
    }

    private void DefineStart()
    {
        generalFunctions = GetComponent<GeneralFunctions>();
        saveData = new SaveData();
        saveData = SaveDataSystem.Load();

        health = saveData.GetPlayerHealth();
        _isControlled = true;
        
        if ((SceneManager.GetActiveScene().name.Contains("Fase")) || (SceneManager.GetActiveScene().name == "Tutorial"))
        {
            DefineStartLevels();
        }
        else
        {
            DefineStartMenus();
        } 
    }

    private void DefineStartLevels()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

        colliderTouch = GetComponent<Collider2D>();
        wavePropagation = GameObject.FindWithTag("WavePropagation");
    }

    private void DefineStartMenus()
    {
        if (SceneManager.GetActiveScene().name == "LevelSeletion")
        {
            DefineStartMenuWorlds();
        }
        if (SceneManager.GetActiveScene().name.Contains("Camada"))
        {
            DefineStartMenuLevels();
        }
        
    }

    private void DefineStartMenuWorlds()
    {
        worldManager = GameObject.FindGameObjectWithTag("WorldManager").GetComponent<WorldManager>();
        worldManager.UnlockedWorlds(saveData);
    }

    private void DefineStartMenuLevels()
    {
        levelManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
        levelManager.UnlockedLevels(saveData);
    }
    #endregion

    #region UPDATE
    void Update()
    {
        ControllerTouch();
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            HealthController();
        }           
    }
    #endregion

    #region TOUCH CONTROLLER
    private void ControllerTouch()
    {
        if ((SceneManager.GetActiveScene().name.Contains("Fase")) || (SceneManager.GetActiveScene().name == "Tutorial"))
        {
            if (_isControlled)
            {
                ControllerTouchInGame();
            }
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
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            GetComponent<GeneralFunctions>().GoToExit();
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "LevelSeletion")
            {
                GetComponent<GeneralFunctions>().GoToMenu();
            }
            else
            {
                GetComponent<GeneralFunctions>().GoToSelection();
            }
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

    #region GETTERS & SETTERS
    public int GetHealth()
    {
        return this.health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public SaveData GetSaveData()
    {
        return this.saveData;
    }

    public void SetControllerActivate(bool activate)
    {
        _isControlled = activate;
    }
    #endregion

    #region HEALTH CONTROLLER
    private void HealthController()
    {
        generalFunctions.Health(GetHealth());
    }
    #endregion
}
