using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorPontuacao : MonoBehaviour
{
    private float miliseconds = 0;
    private int seconds = 0;
    private int minutes = 0;

    private int stars = 0;

    public int timeAlto;
    public int timeMedio;
    public int timeBaixo;
    private int timeTotal; 

    bool isRunning = true;
    // Start is called before the first frame update
    void Start()
    {

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
                GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":0" + seconds + " | " + stars + " estrelas");
            }
            else
            {
                GUI.Label(new Rect(10, 10, 100, 20), "Tempo  0" + minutes + ":" + seconds + " | " + stars + " estrelas");
            }
        }
        else
        {
            if (minutes <= 9)
            {
                if (seconds <= 9)
                {
                    GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":0" + seconds + " | " + stars + " estrelas");
                }
                else
                {
                    GUI.Label(new Rect(10, 10, 100, 20), "Tempo  " + minutes + ":" + seconds + " | " + stars + " estrelas");
                }
            }
        }
    }
}