using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenes : MonoBehaviour
{
    public static bool restart;

    public void loadScene(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void restartLevel()
    {
        Time.timeScale = 1f;
        restart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
