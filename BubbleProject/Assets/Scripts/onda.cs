using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* isso aqui vai criar o GameObject associado ao clicar com o lado esquerdo 
 *  do mouse*/

public class onda : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public void Spanw(Vector3 position)
    {
        Instantiate(gameObject).transform.position = position;
        // cria o objeto que faz a 'onda'
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 ponto = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            // segundo a Unity doc : Transforma um ponto do espaço da tela em espaço do mundo, onde o espaço do mundo é 
            //definido como o sistema de coordenadas no topo da hierarquia do seu jogo.
            // pega a posição do mouse que está na tela ( visão da camêra )
            Vector3 pontoZ = new Vector3(ponto.x, ponto.y, gameObject.transform.position.z);
            // a camêra está em (0, 0, -10), isso é pra que o objeto apareça
            Spanw(pontoZ);
            Destroy(gameObject, 3.5f);
        }

    }
}
