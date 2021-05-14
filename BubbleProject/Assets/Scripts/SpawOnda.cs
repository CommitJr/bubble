
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOnda : MonoBehaviour
{
    [SerializeField] private GameObject ondaPrefab;
    [SerializeField] private Transform spawnPosition;
    private Contador contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = new Contador(3);
    }

    // Update is called once per frame
    void Update(){
    
        if(contador.RepeatCountTime()){
            CriaOnda();
        }
    }

    private void CriaOnda(){
        Instantiate(ondaPrefab, spawnPosition.position, Quaternion.identity);
    }

    

}
