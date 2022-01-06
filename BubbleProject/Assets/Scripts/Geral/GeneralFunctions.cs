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
    private AudioSource audioSource;
    private bool _hasAudio;
    private SaveData saveData;

    private  bool _isPause;
    private  bool _isRunning;
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

        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            DefineStartLevels();
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
        audioSource = GameObject.FindWithTag("AmbientSound") ? GameObject.FindWithTag("AmbientSound").GetComponent<AudioSource>() : null;
        timer = GameObject.FindWithTag("Timer");
        _hasAudio = true;
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvasTutorial = GameObject.FindWithTag("CanvasTutorial");
            _hasAudio = false;
        }
    }
    #endregion

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

    #region SCENES
    public void Restart()
    {
        Debug.Log("Reiniciando..");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Next()
    {
        Debug.Log("Proxima Cena..");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Load(string nome)
    {
        Debug.Log("Carregando..");
        Time.timeScale = 1f;
        SceneManager.LoadScene(nome);
    }

    public void GoToMenu()
    {
        Debug.Log("Indo Para o Menu..");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void GoToSelection()
    {
        Debug.Log("Indo Para a Seleção de Camadas..");
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSeletion");
    }

    public void GoToExit()
    {
        Debug.Log("Saindo..");
        Application.Quit();
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

                audioSource.enabled = false;
                break;
        }
    }
    #endregion

    #region INGAME
    public void GoToEnd()
    {
        playerController.SetControllerActivate(false);

        if (_hasAudio)
        {
            audioSource.enabled = false;
        }

        Debug.Log("Salvando Progresso..");
        SaveDataCheck();
    }

    public void SaveDataCheck()
    {
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

        for (int i = 0; i < saveData.GetWorlds().Count; i++)
        {
            if (saveData.GetWorlds()[i].GetId() == world)
            {
                for (int j = 0; j < saveData.GetWorlds()[i].GetLevels().Count; j++)
                {
                    if (saveData.GetWorlds()[i].GetLevels()[j].GetName() == SceneManager.GetActiveScene().name)
                    {
                        if (saveData.GetWorlds()[i].GetLevels()[j].GetPlayerScore() < timer.GetComponent<Timer>().GetScore())
                        {
                            saveData.GetWorlds()[i].GetLevels()[j].SetPlayerScore(timer.GetComponent<Timer>().GetScore());
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
