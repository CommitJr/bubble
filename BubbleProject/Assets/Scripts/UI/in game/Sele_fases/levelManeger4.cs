using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManeger4 : MonoBehaviour
{
    [SerializeField] public Button[] levelButtons;
    [SerializeField] public GameObject[] levelLockers;
    public int level;

    void Start()
    {
        playerData data = saveSystem.LoadPlayer();
        if (data == null)
        {
            level = 1;
        }
        else
        {
            level = data.level2;
        }

        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
            levelLockers[i].SetActive(true);
        }

        for (int i = 0; i < level; i++)
        {
            levelButtons[i].interactable = true;
            levelLockers[i].SetActive(false);
        }
    }
}
