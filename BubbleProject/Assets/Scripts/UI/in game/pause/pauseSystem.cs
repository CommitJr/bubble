using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class pauseSystem : MonoBehaviour
{
    public static bool pausa = false;
    [SerializeField] private GameObject pausaMenuUI;
    [SerializeField] private GameObject superiorUIGame;
    [SerializeField] private GameObject inferiorUIGame;

    public void Resumo()
    {
        pausaMenuUI.SetActive(false);
        superiorUIGame.SetActive(true);
        inferiorUIGame.SetActive(true);
        Time.timeScale = 1f;
        pausa = false;
    }

    public void Pause()
    {
        //Debug.Log("pausa");
        pausaMenuUI.SetActive(true);
        superiorUIGame.SetActive(false);
        inferiorUIGame.SetActive(false);
        Time.timeScale = 0f;
        pausa = true;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SairButton()
    {
        Application.Quit();
    }
}
