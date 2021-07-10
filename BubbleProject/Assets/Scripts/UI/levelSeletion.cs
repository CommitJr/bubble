using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSeletion : MonoBehaviour
{
    [SerializeField] public Button[] levelButtons;
    // Start is called before the first frame update
    [SerializeField] public GameObject[] levelLockers;

    void Start()
    {
        int currentLevel = PlayerPrefs.GetInt("levelAt", 2);
        // deveria pegar a quantidade de fases dentro da camada
        // teria como acessar isso?
        for(int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > currentLevel)
            {
                levelButtons[i].interactable = false;
                //levelLockers[i].SetActive(true);
            }
            
        }
    }

}
