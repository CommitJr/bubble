using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwEnemy : MonoBehaviour
{

    [SerializeField] private GameObject[] enemies;
    private Contador cont;
    [SerializeField] private float timerForSpawn;
    private Contador recharge;
    private int enemy;
    void Start()
    {
        cont = new Contador(timerForSpawn);
        recharge = new Contador(timerForSpawn*2);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        RechargeEnemy();
    }
    private void SpawnEnemy()
    {
        if (cont.RepeatCountTime())
        {
            enemy = Random.Range(0, 3);
            
            if (GameObject.Find(enemies[enemy].name + "(Clone)") == null)
            {
                this.transform.GetChild(enemy).GetComponent<SpriteRenderer>().enabled = false;
                Instantiate(enemies[enemy], transform.position, Quaternion.identity);
            }
        }
    }

    private void RechargeEnemy()
    {
        if (recharge.RepeatCountTime())
        {
            this.transform.GetChild(enemy).GetComponent<SpriteRenderer>().enabled = true;
            Destroy(GameObject.Find(enemies[enemy].name + "(Clone)"));
        }
    }
}
