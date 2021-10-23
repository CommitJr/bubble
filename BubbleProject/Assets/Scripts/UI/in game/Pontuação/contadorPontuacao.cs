using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contadorPontuacao : MonoBehaviour
{
    [SerializeField] int timeAlto;
    public int timeMedio;
    public int timeBaixo;
    private int timeTotal;

    private float miliseconds = 0;
    public int seconds = 0;
    public int minutes = 0;

    public int stars;

     

    bool isRunning;

    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        contaTempo();
    }

    private void contaTempo()
    {
        if (isRunning)
        {
            miliseconds += Time.deltaTime * 1000;

            if (miliseconds >= 1000)
            {
                seconds++;
                miliseconds = 0;
            }

            if (seconds >= 59)
            {
                minutes++;
                seconds = 0;
            }

            if (seconds < 0)
                isRunning = false;
        }

        timeTotal = minutes * 60 + seconds;

        if (timeTotal <= timeAlto)
        {
            stars = 3;
        }
        else if (timeTotal <= timeMedio)
        {
            stars = 2;
        }
        else if (timeTotal <= timeBaixo)
        {
            stars = 1;
        }
        else
        {
            stars = 0;
        }
    }
    private void OnGUI()
    {
        if (minutes <= 9)
        {
            if (seconds <= 9)
            {
               text.SetText("0{0}:0{1}", minutes, seconds);
                //    GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":0" + seconds + " | " + stars + " estrelas");
            }
            else
            {
                text.SetText("0{0}:{1}", minutes, seconds);
                // GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":" + seconds + " | " + stars + " estrelas");
            }
        }
        else
        {
            if (minutes <= 9)
            {
                if (seconds <= 9)
                {
                    text.SetText("{0}:0{1}", minutes, seconds);
                    //  GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":0" + seconds + " | " + stars + " estrelas");
                }
                else
                {
                    text.SetText("{0}:0{1}", minutes, seconds);
                  //  GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":" + seconds + " | " + stars + " estrelas");
                }
            }
        }
    }
}