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
        SpawnEnemy();
        if ( zigzag.waypointIndex %3 == 0 && !_canChange) // descendo
        {
            arraia[0].SetActive(true);
            arraia[1].SetActive(false);
                        
            _canChange = true;
            Debug.Log("descendo");
        }
        else if(zigzag.waypointIndex %2 ==0 && _canChange) // subindo
        {
            arraia[0].SetActive(false);
            arraia[1].SetActive(true);

            Debug.Log("subindo");
            _canChange = false;
        }
    }

    private void SpawnEnemy()
    {
        if (cont.RepeatCountTime())
        {
            Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.identity);
            //Instantiate(enemies[Random.Range(0, 2)], transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 180))));
        }
    }
}
