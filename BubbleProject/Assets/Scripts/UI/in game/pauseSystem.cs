using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class pauseSystem : MonoBehaviour
{
    public static bool pausa = false;
    [SerializeField] private GameObject pausaMenuUI;
    // Update is called once per frame
    void OnMouseDown()
    {
         if (pausa)
        { 
                Resumo();
            }
          else
          {
              Pause();
         }
        
    }
    public void Resumo()
    {
        pausaMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pausa = false;
    }
    void Pause()
    {
        pausaMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pausa = true;
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SairButton()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
