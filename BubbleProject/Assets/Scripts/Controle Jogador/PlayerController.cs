using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region SCOPE
    private int health;
    private bool _isControlled;
    private bool _isDead;

    private Collider2D colliderTouch;
    private GameObject wavePropagation;

    private GeneralFunctions generalFunctions;
    private SaveData saveData;

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
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();

            colliderTouch = GetComponent<Collider2D>();
            wavePropagation = GameObject.FindWithTag("WavePropagation");

            generalFunctions = GetComponent<GeneralFunctions>();
            //saveData = new SaveData();
            //saveData = SaveDataSystem.Load();

            health = 3;//saveData.GetPlayerHealth();
            _isControlled = true;
            _isDead = false;


        }
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

    void FixedUpdate()
    {
        if (!_isDead)
        {
            HealthCheck();
        }
        

    }
    
    #region TOUCH CONTROLLER
    private void ControllerTouch()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 7)
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
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            GetComponent<GeneralFunctions>().GoToExit();
        }
        else
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
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

    private void DeathAnimation()
    {
        Instantiate(death, transform.position, transform.rotation);
        player.parent.gameObject.SetActive(false);
        Invoke("defeatTime", 0.99f);
    }

    #region DEATH
    private void defeatTime()
    {
        generalFunctions.Defeat();
        Destroy(GameObject.FindWithTag("death"));
    }
    #endregion

    private void HealthCheck()
    {
        switch (GetHealth())
        {
            case 0:
                Debug.Log("chama o estouro da bolha");
                DeathAnimation();
                _isDead = true;
                break;
        }
    }


}
