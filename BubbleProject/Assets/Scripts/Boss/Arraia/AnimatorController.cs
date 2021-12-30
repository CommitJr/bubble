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
    private bool _canChange;
    private GameObject enemy;
    void Start()
    {
        cont = new Contador(timerForSpawn);
        _canChange = true;
    }

    void Update()
    {
        ChangeFish();
    }

    private void ChangeFish()
    {
       
        if(zigzag.waypointIndex %2 == 0 && _canChange) // nadando de lado
        {
            arraia[0].SetActive(false);
            arraia[1].SetActive(true);

            arraia[1].transform.rotation = Quaternion.Euler(0, 180, 0);
            Debug.Log("de lado");
            _canChange = false;
        }

         else if( zigzag.waypointIndex == 3 && !_canChange) // descendo
        {
            arraia[0].SetActive(true);
            arraia[1].SetActive(false);

            arraia[0].transform.rotation = Quaternion.Euler(180, 0, 0);
            SpawnEnemy();
            _canChange = true;
            Debug.Log("descendo");
        }
        else if(zigzag.waypointIndex == 1 || zigzag.waypointIndex == 5 && _canChange) // subindo
        {
            arraia[0].SetActive(true);
            arraia[1].SetActive(false);

            arraia[0].transform.rotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("subindo");
            _canChange = false;
        }
    }

    private void SpawnEnemy()
    {
        if (cont.RepeatCountTime())
        {
            //   Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.identity);
            Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.Euler(new Vector3(0, Random.Range(0, 180), 0)));
        }
    }
}
