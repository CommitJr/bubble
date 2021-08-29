using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class worldManager : MonoBehaviour
{
    [SerializeField] public Button[] worldButtons;
    [SerializeField] public GameObject[] levelLockers;
    int world;

    void Start()
    {
        playerData data = saveSystem.LoadPlayer();
        if (data == null)
        {
            world = 1;
        }
        else
        {
            world = data.world;
        }

        for (int i = 0; i < worldButtons.Length; i++)
        {
            worldButtons[i].interactable = false;
            levelLockers[i].SetActive(true);
        }

        for (int i = 0; i < world; i++)
        {
            worldButtons[i].interactable = true;
            levelLockers[i].SetActive(false);
        }
    }
}
