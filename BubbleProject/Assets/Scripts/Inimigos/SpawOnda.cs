
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOnda : MonoBehaviour
{
    [SerializeField] private GameObject ondaPrefab;
    [SerializeField] private Transform spawnPosition;
    private Contador contador;
    [SerializeField] private int temporizador;
    // Start is called before the first frame update
    void Start()
    {
        contador = new Contador(temporizador);
    }

    // Update is called once per frame
    void Update(){
    
        if(contador.RepeatCountTime()){
            CriaOnda();
        }
    }

    private void CriaOnda(){
        spawnPosition.eulerAngles = gameObject.GetComponent<Transform>().eulerAngles;
        Instantiate(ondaPrefab, spawnPosition.position, spawnPosition.rotation);
    }

    

}
