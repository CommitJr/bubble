using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativaCanvas : MonoBehaviour
{
    [SerializeField] private GameObject desativa;
    [SerializeField] private GameObject ativa;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private bool _isActivated;

    public void Action() {
        desativa.SetActive(false);
        ativa.SetActive(true);

        if(_isActivated)
        {
            playerController.enabled = true;
        }
    }
}
