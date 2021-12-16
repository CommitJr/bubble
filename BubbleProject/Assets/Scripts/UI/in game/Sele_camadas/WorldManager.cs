using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldManager : MonoBehaviour
{
    [SerializeField] public Button[] worldButtons;
    [SerializeField] public GameObject[] worldLockers;
    [SerializeField] public GameObject[] worldTextLock;
    [SerializeField] public GameObject[] worldTextUnlock;

    public void UnlockedWorlds(SaveData GameData)
    {
        for (int i = 0; i < GameData.GetUnlockedWorlds(); i++)
        {
            worldButtons[i].interactable = true;
            worldLockers[i].SetActive(false);
            worldTextLock[i].SetActive(false);
            worldTextUnlock[i].SetActive(true);
        }
    }
}
