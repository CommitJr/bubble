using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    [SerializeField] private ZigZag zigzag;
    [SerializeField] private GameObject[] arraia;       
    [SerializeField] private GameObject[] enemies;   
    private Contador cont;
    [SerializeField] private float timerForSpawn;
    private bool _canChange = true;
    private GameObject enemy;
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
       
        if(zigzag.waypointIndex %2 == 0 && zigzag.waypointIndex > 0 && _canChange)
         {
            _canChange = false;

            arraia[0].SetActive(false);
            arraia[1].SetActive(true);

        }

         else if( zigzag.waypointIndex == 3 || zigzag.waypointIndex == 4 && !_canChange)
         {
            _canChange = true;

            arraia[0].SetActive(true);
            arraia[1].SetActive(false);

            arraia[1].transform.rotation = Quaternion.Euler(180, 0, 0);
            SpawnEnemy();
         }
       
        

    }

    private void SpawnEnemy()
    {
        if (cont.RepeatCountTime())
        {
            //   Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.identity);
            Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.Euler(new Vector3(Random.Range(0, 180), 0, 0)));
        }
    }
}
