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

    private PlayerController PlayerController;
    private BubbleController bubbleController;
    private AudioSource audioSource;

    private  bool _isPause;
    private  bool _isRestart;
    #endregion

    #region START
    void Start()
    {
        DefineStart();
    }

    private void DefineStart() {     
        _isPause = false;
        _isRestart = false;

        PlayerController = GetComponent<PlayerController>();

        if (SceneManager.GetActiveScene().buildIndex >= 7) 
        {
            bubbleController = GameObject.FindWithTag("Player").GetComponent<BubbleController>();
        }

        audioSource = GameObject.FindWithTag("Ambient Sound").GetComponent<AudioSource>();
    }
    #endregion

    #region PAUSE
    public void PauseController() 
    {
        if (!_isPause)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    private void Resume()
    {
        Debug.Log("Retomando..");
        pauseMenuUI.SetActive(false);
        header.SetActive(true);
        footer.SetActive(true);
        Time.timeScale = 1f;
        _isPause = false;
    }

    private void Pause()
    {
        Debug.Log("Pausando..");
        pauseMenuUI.SetActive(true);
        header.SetActive(false);
        footer.SetActive(false);
        Time.timeScale = 0f;
        _isPause = true;
    }
    #endregion

    #region SCENES
    public void Restart()
    {
        Debug.Log("Reiniciando..");
        Time.timeScale = 1f;
        _isRestart = true;
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
    }

    public void Defeat()
    {
        Debug.Log("Perdeu!");
        defeatMenuUI.SetActive(true);
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
        PlayerController.SetControllerActivate(false);

        audioSource.enabled = false;
    }
    #endregion
}
