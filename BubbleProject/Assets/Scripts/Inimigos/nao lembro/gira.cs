using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gira : MonoBehaviour
{
    [Header("Movimento")]
    [SerializeField] private float angulacao = 1;
    [Header("Componentes")]
    [SerializeField] private Transform inimigoT;

    void OnCollisionEnter2D(Collision2D parede)
    {
        if (parede.transform.tag == "parede" || parede.transform.tag == "Pedras")
        {
            angulacao *= -1;
            Quaternion target = Quaternion.Euler(0, 0, angulacao);
            inimigoT.rotation = Quaternion.Slerp(inimigoT.rotation, target,  Time.deltaTime * 2);
        }
    }
}