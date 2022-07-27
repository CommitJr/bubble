using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public Button[] levelButtons;
    [SerializeField] public GameObject[] levelLockers;
    [SerializeField] public GameObject[] levelScore;

    public void UnlockedLevels(SaveData GameData)
    {
        World WorldFather = new World();
        switch (SceneManager.GetActiveScene().name)
        {
            case "Camada5":
                WorldFather = GameData.GetWorlds(5);
                break;
            case "Camada4":
                WorldFather = GameData.GetWorlds(4);
                break;
            case "Camada3":
                WorldFather = GameData.GetWorlds(3);
                break;
            case "Camada2":
                WorldFather = GameData.GetWorlds(2);
                break;
            case "Camada1":
                WorldFather = GameData.GetWorlds(1);
                break;
        }

        for (int i = 0; i < WorldFather.GetUnlockedLevels(); i++)
        {
            levelButtons[i].interactable = true;
            levelLockers[i].SetActive(false);
            if(WorldFather.GetLevels()[i].GetPlayerScore() > 0)
            {
                levelScore[i].transform.GetChild(WorldFather.GetLevels()[i].GetPlayerScore() - 1).gameObject.GetComponent<Image>().enabled = true;
            }  
        }
    }
}
