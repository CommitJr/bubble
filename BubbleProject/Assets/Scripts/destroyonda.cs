﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyonda : MonoBehaviour
{

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "WavePropagation(Clone)")
        {
            Destroy(gameObject, 2);
        }
    }

}