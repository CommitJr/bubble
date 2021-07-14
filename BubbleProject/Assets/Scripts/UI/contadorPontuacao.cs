using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contadorPontuacao : MonoBehaviour
{
    private float miliseconds = 0;
    private int seconds = 0;
    private int minutes = 0;

    public int stars;

    public int timeAlto;
    public int timeMedio;
    public int timeBaixo;
    private int timeTotal; 

    bool isRunning = true;

    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            miliseconds += Time.deltaTime * 1000;

           // GetComponent<Text>().text = "Tempo: " + Mathf.RoundToInt(timer).ToString() + " s";
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
        Debug.Log(stars);
        if(timeTotal <= timeAlto)
        {
            stars = 3;
        }
        else if (timeTotal <= timeMedio)
        {
            stars = 2;
        }
        else if(timeTotal <= timeBaixo)
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