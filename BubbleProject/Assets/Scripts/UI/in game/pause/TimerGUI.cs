using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerGUI : MonoBehaviour
{
    #region SCOPE
    private GameObject timer;
    private TextMeshProUGUI text;

    private string textGUI;
    #endregion

    #region START
    void Start()
    {
        timer = GameObject.FindGameObjectWithTag("Timer");
        text = GetComponent<TextMeshProUGUI>();
    }
    #endregion

    #region UPDATE
    void Update()
    {
        DisplayGUI();
    }
    #endregion

    #region GUI
    private void OnGUI()
    {
        DisplayGUI();
    }

    private void DisplayGUI()
    {
        text.SetText(TextGUI());
    }

    private string TextGUI()
    {

        textGUI = timer.GetComponent<Timer>().GetTime();

        return textGUI;
    }
    #endregion
}
