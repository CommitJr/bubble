using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class metersCounter : MonoBehaviour
{
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject endGame;

    private int metros;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        metros = 0;
        text = GetComponent<TextMeshProUGUI>();
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
