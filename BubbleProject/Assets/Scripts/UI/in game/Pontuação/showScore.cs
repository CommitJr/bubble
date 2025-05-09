﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    [SerializeField]
    private GameObject shell0;
    [SerializeField]
    private GameObject shell1;
    [SerializeField]
    private GameObject shell2;
    [SerializeField]
    private GameObject shell3;
    [SerializeField] contadorPontuacao score;

    // Update is called once per frame
    void Update()
    {
        if (score.stars == 3)
        {
            shell0.SetActive(false);
            shell1.SetActive(false);
            shell2.SetActive(false);
            shell3.SetActive(true);
        }
        else if (score.stars == 2)
        {
            shell0.SetActive(false);
            shell1.SetActive(false);
            shell2.SetActive(true);
            shell3.SetActive(false);
        }
        else if (score.stars == 1)
        {
            shell0.SetActive(false);
            shell1.SetActive(true);
            shell2.SetActive(false);
            shell3.SetActive(false);
        }
        else
        {
            shell0.SetActive(true);
            shell1.SetActive(false);
            shell2.SetActive(false);
            shell3.SetActive(false);
        }
    }
}