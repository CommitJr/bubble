using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarArpao : MonoBehaviour
{
    #region SCOPE
    [SerializeField] private GameObject arpao;
    [SerializeField] private Transform spawnZone;
    [SerializeField] private int time;
    private Contador contador;
    private AudioSource arpaoSound;
    #endregion

    #region START
    void Start()
    {
        contador = new Contador(time);
        arpaoSound = GetComponent<AudioSource>();
        arpaoSound.Stop();
    }
    #endregion

    #region UPDATE
    void Update()
    {
        Attack();
    }
    #endregion

    #region METHODS
    private void Attack()
    {
        if (contador.RepeatCountTime())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        if (GameObject.FindWithTag("Player") != null && Vector3.Distance(GameObject.FindWithTag("Player").transform.position, gameObject.transform.position) <= 35)
        {
            gameObject.GetComponent<Animator>().SetTrigger("_isAttacking");
            arpaoSound.Play();
            Instantiate(arpao, spawnZone.position, gameObject.transform.rotation);
            GameObject.FindWithTag("Arpao").GetComponent<NomeAtirador>().SetShooterName(gameObject.name);
        }
    }
    #endregion
}
