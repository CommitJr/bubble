using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grito : MonoBehaviour
{
   [SerializeField] private GameObject ondaPrefab;
    [SerializeField] private Transform spawnPosition;
    private Contador contador;

    [SerializeField] private int temporizador;
    // Start is called before the first frame update
    void Start()
    {
        contador = new Contador(3);
        contador = new Contador(temporizador);
    }

    // Update is called once per frame
    void Update(){
    
        if(contador.RepeatCountTime()){
            CriaOnda();
        }
    }
    private void CriaOnda(){
        Instantiate(ondaPrefab, spawnPosition.position, Quaternion.identity);
        Destroy(ondaPrefab, 4f);
    }

}
