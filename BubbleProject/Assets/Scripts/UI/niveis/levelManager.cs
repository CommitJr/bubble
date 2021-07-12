using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    [SerializeField] public Button[] levelButtons;
    [SerializeField] public GameObject[] levelLockers;
    int sceneInitial;

    void Start()
    {
        sceneInitial = PlayerPrefs.GetInt("levelCompleted", 1);
        print(sceneInitial);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
             levelLockers[i].SetActive(true);
        }

        for (int i = 0; i < sceneInitial; i++)
        {
            levelButtons[i].interactable = true;
            levelLockers[i].SetActive(false);
        }
    }
}
