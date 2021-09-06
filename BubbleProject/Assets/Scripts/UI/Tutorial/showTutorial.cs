using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showTutorial : MonoBehaviour
{
    [SerializeField] private GameObject TutorialUI;
    public void show()
    {
        playerData data = saveSystem.LoadPlayer();
        if (data == null)
        {
            TutorialUI.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
