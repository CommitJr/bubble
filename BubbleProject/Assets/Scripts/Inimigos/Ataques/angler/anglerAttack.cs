using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anglerAttack : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D intensity;
    private Vector2 direction;
    private GameObject player;
    private Contador contador;
    private bool ativado;
    // Start is called before the first frame update
    void Start()
    {
        intensity = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
        player = GameObject.FindWithTag("Player");
        contador = new Contador(.25f);
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.transform.position - transform.position);
        if (direction.magnitude < 6) {
            lightAttack();
        }
        else
        {
            intensity.intensity = 0.8f;
            intensity.pointLightOuterRadius = 0.5f;
        }
       
    }

    void lightAttack() {
        if (contador.RepeatCountTime())
        {

            if (ativado)
            {
                intensity.intensity = 10;
                intensity.pointLightOuterRadius = 10;
                ativado = false;
            }
            else 
            {
                intensity.intensity = 1;
                ativado = true;
            }

        }
    }
}
