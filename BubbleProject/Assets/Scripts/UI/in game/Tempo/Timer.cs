using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    #region SCOPE
    [SerializeField] int highTime;
    [SerializeField] int middleTime;
    [SerializeField] int lowTime;

    private float miliseconds;
    private int seconds;
    private int minutes;
    private int totalTime;

    private int stars;
    private bool _isRunning;

    private TextMeshProUGUI text;
    #endregion

    #region START
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        _isRunning = true;

        miliseconds = 0;
        seconds = 0;
        minutes = 0;
        totalTime = 0;
    }
    #endregion

    #region UPDATE
    void Update()
    {
        CounterController();
    }
    #endregion

    #region COUNTER
    private void CounterController()
    {
        if (_isRunning)
        {
            Counter();
        }

        CounterStars();
    }

    public void StopCounter()
    {
        _isRunning = false;
    }

    private void CounterStars(){
        if (totalTime <= highTime)
        {
            stars = 3;
        } else if (totalTime <= middleTime) 
        {
            stars = 2;
        }else if (totalTime <= lowTime)
        {
            stars = 1;
        }
        else
        {
            stars = 0;
        }
    }

    private void Counter()
    { 
        Miliseconds();
        Seconds();
        Minutes();
        TotalTime();
    }

    private void Miliseconds()
    {
        miliseconds += Time.deltaTime * 1000;
    }

    private void Seconds()
    {
        if (miliseconds >= 1000)
        {
            seconds++;
            miliseconds = 0;
        }
    }

    private void Minutes()
    {
        if (seconds >= 59)
        {
            minutes++;
            seconds = 0;
        }
    }
    
    private void TotalTime()
    {
        totalTime = minutes * 60 + seconds;
    }
    #endregion

    #region GETTER
    public int GetScore()
    {
        return stars;
    }

    public string GetTime()
    {
        return GUIFormat();
    }
    #endregion

    #region GUI
    private string GUIFormat()
    {
        if (minutes <= 9)
        {
            if (seconds <= 9)
            {
                return "0"+minutes+":0"+seconds;
            }
            else
            {
                return "0" + minutes + ":" + seconds;
            }
        }
        else
        {
            if (seconds <= 9)
            {
                return minutes + ":0" + seconds;
            }
            else
            {
                return minutes + ":" + seconds;
            }
        }
    }
    #endregion
}
