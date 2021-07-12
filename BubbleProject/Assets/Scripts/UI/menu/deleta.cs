using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleta : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
