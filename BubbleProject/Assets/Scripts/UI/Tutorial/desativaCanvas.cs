using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativaCanvas : MonoBehaviour
{
    [SerializeField] private GameObject desativa;
    [SerializeField] private GameObject ativa;

    public void Action() {
        desativa.SetActive(false);
        ativa.SetActive(true);
    }
}
