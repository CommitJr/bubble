using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldManager : MonoBehaviour
{
    [SerializeField] public Button[] worldButtons;
    [SerializeField] public GameObject[] worldLockers;

    public void UnlockedWorlds(SaveData GameData)
    {
        for (int i = 0; i < GameData.GetUnlockedWorlds(); i++)
        {
            worldButtons[i].interactable = true;
            worldLockers[i].SetActive(false);
        }
    }
}
