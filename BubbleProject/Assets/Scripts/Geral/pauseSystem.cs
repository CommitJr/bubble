using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseSystem : MonoBehaviour
{
    public static bool pausa = false;
    public GameObject pausaMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
