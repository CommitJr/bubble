using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    /*
     ARRAIAF NADA ATÉ UM PONTO
    ARRAIAF C2HEGA AO PONTO 1
    ARRAIAF SOME
    ARRAIAL APARECE
    SPAWNA INIMIGOS
    ARRAIAL CHEGA AO PONTO 2
    ARRAIAL SOME
    ARRAIAC APARACE
    */
    [SerializeField] private ZigZag zigzag;
    [SerializeField] private GameObject[] arraia;       // são duas arraias, 0 - L, 1 - F
    [SerializeField] private GameObject[] enymies;      // são três peixes
    private Contador cont;
    [SerializeField] private float timerForSpawn;
    void Start()
    {
        cont = new Contador(timerForSpawn);
    }

    void Update()
    {
        ChangeFish();
    }

    private void ChangeFish()
    {
        if(zigzag.waypointIndex %2 == 0)
         {
             // arraiaL
             arraia[1].SetActive(true);
             arraia[0].SetActive(false);
         }

         else
         {
             // arraiaF
             SpawnEnimy();

         }

    }

    private void SpawnEnimy()
    {
        if (cont.RepeatCountTime())
        {
            // inimigo randomico
            // soltagem: da posição da arraia transform.position
            // ele caí, alguns quadradinhos gravity
            // depois o proprio prefab assume
                // ativa tudooo
        }
    }
}
