using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class metersCounter : MonoBehaviour
{
    private GameObject player;
    private GameObject endGame;

    private int metros;
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        metros = 0;
        text = GetComponent<TextMeshProUGUI>();
        player = GameObject.FindWithTag("BolhaRastreio");
        endGame = GameObject.FindWithTag("End");
    }

    private void Update()
    {
        metros = ((int)Vector3.Distance(player.transform.position, endGame.transform.position));
        if (metros > 9)
        {
            text.SetText("{0} metros restantes", metros);
        }
        else {
            text.SetText("0{0} metros restantes", metros);
        }   
    }
}
