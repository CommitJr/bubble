﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class passaFase : MonoBehaviour
{
    //[SerializeField]  public int next;
    // Start is called before the first frame update
    void Start()
    {
        //next = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("trocou a fase");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("levelCompleted")) {
                PlayerPrefs.SetInt("levelCompleted", SceneManager.GetActiveScene().buildIndex);
                PlayerPrefs.Save();
            }
            //PlayerPrefs.SetInt("levelAt", SceneManager.GetActiveScene().buildIndex);
        }
    }
}