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
    [SerializeField] private Animator scene_transition;
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider slider;


    private GameObject timer;
    private GameObject canvasTutorial;

    private GameObject time;
    private PlayerController playerController;
    private BubbleController bubbleController;
    private SaveData saveData;
    //    private GameControl gameControl;
 //   private UnitySave cloudSave;
    private AdsManager adsManager;

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

        //   gameControl = new GameControl();
        time = GameObject.FindWithTag("Timer");
        playerController = GetComponent<PlayerController>();
        buttonSound = GetComponent<AudioSource>();
        adsManager = GameObject.FindGameObjectWithTag("Ads").GetComponent<AdsManager>();

        if (SceneManager.GetActiveScene().name.Contains("Fase") || SceneManager.GetActiveScene().name == "Tutorial")
        {
            DefineStartLevels();
            player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        }
        else
        {
            DefineStartMenus();
        }

        // ---------------- CLOUD SAVE ------------------------
        // Subscribe to cloud save service events
    //    UnitySave.Instance.OnCloudDataRetrieved += UnitySave.Instance.OnCloudDataRetrievedHandler;
             
    }

    private void DefineStartMenus()
    {
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            adsManager.LoadAdBanner();
        }
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
        //Debug.Log("Retomando..");
        pauseMenuUI.SetActive(false);
        header.SetActive(true);
        footer.SetActive(true);

        adsManager.HideBannerAd();

        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvasTutorial.SetActive(true);
        }

        Time.timeScale = 1f;
    }

    private void Pause()
    {
        //Debug.Log("Pausando..");
        pauseMenuUI.SetActive(true);
        header.SetActive(false);
        footer.SetActive(false);

        adsManager.LoadAdBanner();

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
    #region RESTART 
    public void Restart()
    {
        //Debug.Log("Reiniciando..");

        if (!_isPlaying)
        {
            StartCoroutine(restart());
           
        }
    }
    private IEnumerator restart()
    {
        Time.timeScale = 1f;
        scene_transition.SetTrigger("start");

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        adsManager.HideBannerAd();
    }
    #endregion

    #region NEXT
    public void Next()
    {
        if (!_isPlaying)
        {
            //Debug.Log("Proxima Cena..");
            StartCoroutine(next());
            
        }
    }
    private IEnumerator next()
    {
        scene_transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        adsManager.HideBannerAd();
    }

    #endregion

    #region LOAD
    public void Load(string nome)
    {
        if (!_isPlaying)
        {
            //Debug.Log("Carregando..");
            StartCoroutine(load(nome));
        }

    }
    private IEnumerator load(string nome)
    {
       
      //  yield return new WaitForSeconds(1f);

        AsyncOperation operation = SceneManager.LoadSceneAsync(nome);
        scene_transition.SetTrigger("start");
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .1f);
            slider.value = progress;
            yield return null;
        }
    }

    #endregion

    #region GO TO MENU
    public void GoToMenu()
    {
        //Debug.Log("Indo Para o Menu..");
        if (!_isPlaying)
        {
            StartCoroutine(gotomenu());
        }
    }
    private IEnumerator gotomenu()
    {
        Time.timeScale = 1f;
        scene_transition.SetTrigger("start");

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Menu");
    }
    #endregion

    #region GO TO SELECTION
    public void GoToSelection()
    {
        if (!_isPlaying)
        {
            //Debug.Log("Indo Para a Seleção de Camadas..");
            StartCoroutine(gotoselection());
        }
    }
    private IEnumerator gotoselection()
    {
        Time.timeScale = 1f;
        scene_transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("LevelSeletion");
    }
    #endregion

    #region EXIT
    public void GoToExit()
    {
        if (!_isPlaying)
        {
            //Debug.Log("Saindo..");
            StartCoroutine(gotoexit());
        }
    }
    private IEnumerator gotoexit()
    {
        scene_transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
    #endregion

    #endregion

    #region UI
    public void Win()
    {
        //Debug.Log("Ganhou!");
        winMenuUI.SetActive(true);
        _isRunning = false;

        adsManager.LoadAdBanner();

        if (adsManager.GetWinCounter() < 4)
        {
            adsManager.CounterWins(false);
        }
        else
        {
            adsManager.CounterWins(true);
            adsManager.LoadAdInterstitial();
            adsManager.ShowAdInterstitial();
        }
    }

    public void Defeat()
    {
        //Debug.Log("Perdeu!");
        defeatMenuUI.SetActive(true);
        _isRunning = false;

        adsManager.LoadAdBanner();

        if (adsManager.GetDeathCounter() < 3)
        {
            adsManager.CounterDeaths(false);
        }
        else
        {
            adsManager.CounterDeaths(true);
            adsManager.LoadAdInterstitial();
            adsManager.ShowAdInterstitial();
        }
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

        time.GetComponent<Timer>().StopCounter();   
        //Debug.Log("Salvando Progresso..");
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

        SaveDataSystem.SaveJson(saveData);
        // gameControl.Save(saveData);
    }

    public bool GetGameStatus()
    {
        return _isRunning;
    }
    #endregion
}
