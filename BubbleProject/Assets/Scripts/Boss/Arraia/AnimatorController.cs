using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    [SerializeField] private ZigZag zigzag;
    [SerializeField] private GameObject[] arraia;     
    private bool _canChange;
    void Start()
    {
        _canChange = true;
    }

    void Update()
    {
        ChangeFish();
    }

    private void ChangeFish()
    {
        if (!zigzag.canGoBack)
        {
            if (zigzag.waypointIndex % 2 != 0 && !_canChange) // descendo
            {
                if(zigzag.waypointIndex == 5 || zigzag.waypointIndex == 1)
                {
                    arraia[0].SetActive(true);
                    arraia[1].SetActive(false);
                }
                else
                {
                    arraia[0].SetActive(false);
                    arraia[1].SetActive(true);
                }
                _canChange = true;
            }
            else if (zigzag.waypointIndex % 2 == 0 && _canChange) // subindo
            {
                arraia[0].SetActive(true);
                arraia[1].SetActive(false);
               
                _canChange = false;
            }
        }
        else
        {
            if (zigzag.waypointIndex % 2 == 0 && !_canChange) // descendo
            {  
                arraia[0].SetActive(true);
                arraia[1].SetActive(false);

                _canChange = true;
            }
            else if (zigzag.waypointIndex % 2 != 0 && _canChange) // subindo
            {
                if (zigzag.waypointIndex == 3)
                {
                    arraia[0].SetActive(true);
                    arraia[1].SetActive(false);
                }
                else
                {
                    arraia[0].SetActive(false);
                    arraia[1].SetActive(true);
                }
                _canChange = false;
            }
        }
    }   
}
