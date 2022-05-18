using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource normalGameSound;
    [SerializeField] private AudioSource introSound;
    [SerializeField] private AudioSource endSound;
    [SerializeField] private AudioSource hardGameSound;
    [SerializeField] private AudioSource deepSeaSound;

    void Start()
    {
        deepSeaSound.Play();
    }

    private void Update()
    {
        ChangeSound();
    }
    private void ChangeSound()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Inicio":
                if (!introSound.isPlaying)
                {
                    normalGameSound.Stop();
                    introSound.Play();
                    hardGameSound.Stop();
                    endSound.Stop();
                }
                break;

            case "Tchau":
                if (!endSound.isPlaying)
                {
                    normalGameSound.Stop();
                    introSound.Stop();
                    hardGameSound.Stop();
                    endSound.Play();
                }
                break;

            case "Fase 5_4" or "Fase 4_4" or "Fase 3_4" or "Fase 2_4" or "Fase 1_4":
                if (!hardGameSound.isPlaying)
                {
                    normalGameSound.Stop();
                    introSound.Stop();
                    hardGameSound.Play();
                    endSound.Stop();

                    //Debug.Log("a");
                }

                break;

            default:
                if (!normalGameSound.isPlaying)
                {
                    normalGameSound.Play();
                    introSound.Stop();
                    hardGameSound.Stop();
                    endSound.Stop();
                }

                break;
        }
    }

    
}
