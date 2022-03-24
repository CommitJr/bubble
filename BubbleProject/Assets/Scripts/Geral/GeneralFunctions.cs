using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GeneralFunctions : MonoBehaviour
{
    #region SCOPE
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject winMenuUI;
    [SerializeField] private GameObject defeatMenuUI;
    [SerializeField] private GameObject header;
    [SerializeField] private GameObject footer;
    [SerializeField] private Image[] lives;
    private GameObject timer;
    private GameObject canvasTutorial;

    private PlayerController playerController;
    private BubbleController bubbleController;
    private SaveData saveData;

    private  bool _isPause;
    private  bool _isRunning;

    private Transform player;

    private AudioSource buttonSound;
    private bool _isPlaying;
    #endregion

    #region START
    void Start()
    {
        DefineStart();
    }

    private void DefineStart() {     
        _isPause = false;
        _isRunning = true;

        playerController = GetComponent<PlayerController>();
        buttonSound = GetComponent<AudioSource>();

        if (SceneManager.GetActiveScene().name.Contains("Fase") || SceneManager.GetActiveScene().name == "Tutorial")
        {
            DefineStartLevels();
            player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        }
        else
        {
            DefineStartMenus();
        }

 
    }

    private void DefineStartMenus()
    {

    }

    private void DefineStartLevels()
    {
        bubbleController = GameObject.FindWithTag("Player").GetComponent<BubbleController>();
        timer = GameObject.FindWithTag("Timer");
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvasTutorial = GameObject.FindWithTag("CanvasTutorial");
        }
    }
    #endregion

    private void Update()
    {
        _isPlaying = buttonSound.isPlaying;
    }

    #region PAUSE
    public void PauseController() 
    {
        if (!_isPause)
        {
            _isPause = true;
            Pause();
        }
        else
        {
            _isPause = false;
            Resume();
        }
    }

    private void Resume()
    {
        Debug.Log("Retomando..");
        pauseMenuUI.SetActive(false);
        header.SetActive(true);
        footer.SetActive(true);

        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvasTutorial.SetActive(true);
        }

        Time.timeScale = 1f;
    }

    private void Pause()
    {
        Debug.Log("Pausando..");
        pauseMenuUI.SetActive(true);
        header.SetActive(false);
        footer.SetActive(false);
        
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvasTutorial.SetActive(false);
        }

        Time.timeScale = 0f;
    }

    public bool GetPauseStatus()
    {
        return _isPause;
    }
    #endregion

    #region FIND PLAYER
    public bool FindPlayer(Transform center, int distance)
    {
        if (Vector2.Distance(center.position, player.position) < distance)
            return true;
      
        else
            return false;
    }
    #endregion

    #region SCENES
    
 
    public void Restart()
    {
        Debug.Log("Reiniciando..");
        if (!_isPlaying)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    public void Next()
    {
        
        if (!_isPlaying)
        {
            Debug.Log("Proxima Cena..");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Load(string nome)
    {
        if (!_isPlaying)
        {
            Debug.Log("Carregando..");
            Time.timeScale = 1f;
            SceneManager.LoadScene(nome);
        }

    }

    public void GoToMenu()
    {
        Debug.Log("Indo Para o Menu..");
        if (!_isPlaying)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
    }

    public void GoToSelection()
    {
        if (!_isPlaying)
        {
            Debug.Log("Indo Para a Seleção de Camadas..");
            Time.timeScale = 1f;
            SceneManager.LoadScene("LevelSeletion");
        }
    }

    public void GoToExit()
    {
        if (!_isPlaying)
        {
            Debug.Log("Saindo..");
            Application.Quit();
        }
    }
    #endregion

    #region UI
    public void Win()
    {
        Debug.Log("Ganhou!");
        winMenuUI.SetActive(true);
        _isRunning = false;
    }

    public void Defeat()
    {
        Debug.Log("Perdeu!");
        defeatMenuUI.SetActive(true);
        _isRunning = false;
    }

    public void Health(int health)
    {
        switch (health)
        {
            case 3:
                lives[2].enabled = true;
                lives[1].enabled = true;
                lives[0].enabled = true;
                break;
            case 2:
                lives[2].enabled = false;
                lives[1].enabled = true;
                lives[0].enabled = true;
                break;
            case 1:
                lives[2].enabled = false;
                lives[1].enabled = false;
                lives[0].enabled = true;
                break;
            case 0:
                lives[2].enabled = false;
                lives[1].enabled = false;
                lives[0].enabled = false;
                break;
        }
    }
    #endregion

    #region INGAME
    public void GoToEnd()
    {
        playerController.SetControllerActivate(false);

        Debug.Log("Salvando Progresso..");
        SaveDataCheck();
    }

    public void SaveDataCheck()
    {
        if (GameObject.FindGameObjectWithTag("Inimigos") != null)
        {
            GameObject.FindGameObjectWithTag("Inimigos").SetActive(false);
        }
        
        saveData = playerController.GetSaveData();
        int world = 0;
        if (SceneManager.GetActiveScene().name.Contains("5_") || SceneManager.GetActiveScene().name.Contains("Tutorial"))
        {
            world = 5;
        }

        if (SceneManager.GetActiveScene().name.Contains("4_"))
        {
            world = 4;
        }

        if (SceneManager.GetActiveScene().name.Contains("3_"))
        {
            world = 3;
        }

        if (SceneManager.GetActiveScene().name.Contains("2_"))
        {
            world = 2;
        }

        if (SceneManager.GetActiveScene().name.Contains("1_"))
        {
            world = 1;
        }

        for (int i = 0; i < saveData.GetNumberWorlds(); i++)
        {
            if (saveData.GetWorlds()[i].GetId() == world)
            {
                for (int j = 0; j < saveData.GetWorlds()[i].GetNumberLevels(); j++)
                {
                    if (saveData.GetWorlds()[i].GetLevels()[j].GetName() == SceneManager.GetActiveScene().name)
                    {
                        if(SceneManager.GetActiveScene().name != "Tutorial")
                        {
                            if (saveData.GetWorlds()[i].GetLevels()[j].GetPlayerScore() < timer.GetComponent<Timer>().GetScore())
                            {
                                saveData.GetWorlds()[i].GetLevels()[j].SetPlayerScore(timer.GetComponent<Timer>().GetScore());
                            }
                        }              

                        if(saveData.GetWorlds()[i].GetUnlockedLevels() < saveData.GetWorlds()[i].GetNumberLevels())
                        {
                            if (!saveData.GetWorlds()[i].GetLevels()[j + 1].GetStatus())
                            {
                                saveData.GetWorlds()[i].SetUnlockedLevels(saveData.GetWorlds()[i].GetUnlockedLevels() + 1);
                                saveData.GetWorlds()[i].GetLevels()[j + 1].SetStatus(true);
                            }
                        }
                        else
                        {
                            if (saveData.GetUnlockedWorlds() < saveData.GetNumberWorlds())
                            {
                                saveData.SetUnlockedWorlds(saveData.GetUnlockedWorlds() + 1);
                                saveData.GetWorlds()[i + 1].SetStatus(true);
                                saveData.GetWorlds()[i].GetLevels()[0].SetStatus(true);
                            }   
                        }
                        

                        break;
                    }
                }
            }
        }

        SaveDataSystem.Save(saveData);
    }

    public bool GetGameStatus()
    {
        return _isRunning;
    }
    #endregion
}
