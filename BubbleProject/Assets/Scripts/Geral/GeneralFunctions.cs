using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralFunctions : MonoBehaviour
{
    #region SCOPE
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject winMenuUI;
    [SerializeField] private GameObject defeatMenuUI;
    [SerializeField] private GameObject header;
    [SerializeField] private GameObject footer;

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
        Debug.Log("Proxima Fase..");
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
        SceneManager.LoadScene("LevelSelection");
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
    #endregion
}
