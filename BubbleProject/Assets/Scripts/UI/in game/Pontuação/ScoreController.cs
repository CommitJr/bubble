using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    #region SCOPE
    private GameObject shell0;
    private GameObject shell1;
    private GameObject shell2;
    private GameObject shell3;
    private GameObject timer;
    #endregion

    #region START
    void Start()
    {
        shell0 = GameObject.FindWithTag("Shell 0");
        shell1 = GameObject.FindWithTag("Shell 1");
        shell2 = GameObject.FindWithTag("Shell 2");
        shell3 = GameObject.FindWithTag("Shell 3");
        timer = GameObject.FindWithTag("Timer");
    }
    #endregion

    #region UPDATE
    void Update()
    {
        FinalScoreController();
    }
    #endregion

    #region SCORE
    private void FinalScoreController()
    {
        switch (timer.GetComponent<Timer>().GetScore())
        {
            case 0:
                DisplayShell0();
                break;
               
            case 1:
                DisplayShell1();
                break;

            case 2:
                DisplayShell2();
                break;

            case 3:
                DisplayShell3();
                break;
        }
    }

    private void DisplayShell0()
    {
        shell0.SetActive(true);
        shell1.SetActive(false);
        shell2.SetActive(false);
        shell3.SetActive(false);
    }

    private void DisplayShell1()
    {
        shell0.SetActive(false);
        shell1.SetActive(true);
        shell2.SetActive(false);
        shell3.SetActive(false);
    }

    private void DisplayShell2()
    {
        shell0.SetActive(false);
        shell1.SetActive(false);
        shell2.SetActive(true);
        shell3.SetActive(false);
    }

    private void DisplayShell3()
    {
        shell0.SetActive(false);
        shell1.SetActive(false);
        shell2.SetActive(false);
        shell3.SetActive(true);
    }
    #endregion
}
