using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    [SerializeField] public Button[] levelButtons;
    [SerializeField] public int sceneInitial;

    private void Update()
    {
        for(int i = 0; i < levelButtons.Length; i++)
        {
            if (i + sceneInitial > PlayerPrefs.GetInt("levelCompleted")) 
            {
                levelButtons[i].interactable = false;
            }
            
        }
    }
}
