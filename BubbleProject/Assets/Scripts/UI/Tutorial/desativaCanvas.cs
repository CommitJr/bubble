using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativaCanvas : MonoBehaviour
{
    [SerializeField] private GameObject desativa;
    [SerializeField] private GameObject ativa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Action() {
        desativa.SetActive(false);
        ativa.SetActive(true);
    }
}
