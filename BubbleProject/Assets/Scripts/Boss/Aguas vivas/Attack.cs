using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{
    #region SCOPE
    [SerializeField] private GameObject[] alerts;
    [SerializeField] private GameObject[] boss;
    [SerializeField] private ParticleSystem[] attacks;
    [SerializeField] private metersCounter metersCounter;
    [SerializeField] private GeneralFunctions generalFunctions;
    [SerializeField] private int attacksChange;
    private System.Random random;
    private int[] option;
    private int counter;
    private int attacksCount;
    private bool _isWithdrawal;
    private int meters;
    #endregion

    #region START
    void Start()
    {
        random = new System.Random();
        counter = 0;
        attacksCount = 0;
        option = new int[2];
        _isWithdrawal = true;
        meters = 50;
    }
    #endregion

    #region UPDATE
    void Update()
    {
        if (!generalFunctions.GetPauseStatus())
        {
            Attacking();
        }

        if (!generalFunctions.GetGameStatus())
        {
            gameObject.SetActive(false);
        }
        
    }
    #endregion

    #region ATTACK
    private void Attacking()
    {
        if (meters >= 45)
        {
            NextAttack();
        }
        else
        {
            TechnicalWithdrawal();
        }

        if (metersCounter.GetMeters() != 0)
        {
            meters = metersCounter.GetMeters();
        }
    }
    private void NextAttack()
    {
        if (counter == 0)
        {
            option[0] = random.Next(3);
            option[1] = random.Next(3);
            counter++;
        }
        else if(attacksCount <= attacksChange)
        {
            counter++;
            CurrentAttack(option[0]);
        }
        else
        {
            counter++;
            CurrentAttack(option[0], option[1]);
        }
            
 
    }

    private void CurrentAttack(int option)
    {
        if (counter == 2)
        {
            alerts[option].SetActive(true);
        }
        
        if (counter == 31)
        {
            alerts[option].SetActive(false);
            attacks[option].Play(true);
            attacksCount++;
        }

        if(counter == 45)
        {
            counter = 0;  
        }  
    }

    private void CurrentAttack(int option1, int option2)
    {
        if (counter == 2)
        {
            alerts[option1].SetActive(true);
            alerts[option2].SetActive(true);
        }

        if (counter == 31)
        {
            alerts[option1].SetActive(false);
            attacks[option1].Play(true);
            alerts[option2].SetActive(false);
            attacks[option2].Play(true);
            attacksCount++;
        }

        if (counter == 45)
        {
            counter = 0;
        }
    }
    #endregion

    #region TECHNICALWITHDRAWAL
    private void TechnicalWithdrawal()
    {
        if (_isWithdrawal)
        {
            for (int i = 0; i < 3; i++)
            {
                alerts[i].SetActive(false);
                attacks[i].Stop();
                boss[i].GetComponent<Animator>().SetBool("retirada", true);
            }

            gameObject.GetComponent<UpMoving>().enabled = false;
            _isWithdrawal = false;
            counter = 0;
        }
        else
        {

            if (counter >= 15)
            {
                for (int i = 0; i < 3; i++)
                {
                    boss[i].GetComponent<Animator>().SetBool("retirada", false);
                }

                for (int i = 0; i < 3; i++)
                {
                    boss[i].SetActive(false);
                }
            }

            counter++;     
        }
       

        
    }
    #endregion
}
