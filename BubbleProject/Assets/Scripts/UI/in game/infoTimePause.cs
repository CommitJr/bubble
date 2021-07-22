using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class infoTimePause : MonoBehaviour
{
    [SerializeField] private GameObject time;
    private TextMeshProUGUI ptext;
    // Start is called before the first frame update
    void Start()
    {
        ptext = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.GetComponent<contadorPontuacao>().minutes <= 9)
        {
            if (time.GetComponent<contadorPontuacao>().seconds <= 9)
            {
                ptext.SetText("Tempo 0{0}:0{1}", time.GetComponent<contadorPontuacao>().minutes, time.GetComponent<contadorPontuacao>().seconds);
                //    GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":0" + seconds + " | " + stars + " estrelas");
            }
            else
            {
                ptext.SetText("Tempo 0{0}:{1}", time.GetComponent<contadorPontuacao>().minutes, time.GetComponent<contadorPontuacao>().seconds);
                // GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":" + seconds + " | " + stars + " estrelas");
            }
        }
        else
        {
            if (time.GetComponent<contadorPontuacao>().minutes <= 9)
            {
                if (time.GetComponent<contadorPontuacao>().seconds <= 9)
                {
                    ptext.SetText("Tempo {0}:0{1}", time.GetComponent<contadorPontuacao>().minutes, time.GetComponent<contadorPontuacao>().seconds);
                    //  GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":0" + seconds + " | " + stars + " estrelas");
                }
                else
                {
                    ptext.SetText("Tempo {0}:0{1}", time.GetComponent<contadorPontuacao>().minutes, time.GetComponent<contadorPontuacao>().seconds);
                    //  GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":" + seconds + " | " + stars + " estrelas");
                }
            }
        }
    }
}
