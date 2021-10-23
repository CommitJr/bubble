using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    #region SCOPE
    [SerializeField] private GameObject shell0;
    [SerializeField] private GameObject shell1;
    [SerializeField] private GameObject shell2;
    [SerializeField] private GameObject shell3;
    private GameObject timer;
    #endregion

    #region START
    void Start()
    {
        timer = GameObject.FindWithTag("Timer");
        StopTimer();
    }

    private void StopTimer()
    {
        timer.GetComponent<Timer>().StopCounter();
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
