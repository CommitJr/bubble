using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class worldManager : MonoBehaviour
{
    [SerializeField] public Button[] worldButtons;
    [SerializeField] public GameObject[] levelLockers;
    int sceneInitial;

    void Start()
    {
        sceneInitial = PlayerPrefs.GetInt("layerCompleted", 1);
    
        for (int i = 0; i < worldButtons.Length; i++)
        {
            worldButtons[i].interactable = false;
            levelLockers[i].SetActive(true);
        }

        for (int i = 0; i < sceneInitial; i++)
        {
            worldButtons[i].interactable = true;
            levelLockers[i].SetActive(false);
        }
    }
}
