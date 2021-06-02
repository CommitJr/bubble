using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class worldManager : MonoBehaviour
{
    public Button[] worldButtons;

    private void Update()
    {
        for (int i = 0; i < worldButtons.Length; i++)
        {
            if (i + 2 > PlayerPrefs.GetInt("levelCompleted"))
            {
                worldButtons[i].interactable = false;
            }

        }
    }
}
