using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    [SerializeField]
    private Image shell1;
    [SerializeField]
    private Image shell2;
    [SerializeField]
    private Image shell3;
    contadorPontuacao score;

    // Start is called before the first frame update
    void Start()
    {
        shell1 = GetComponent<Image>();
        shell2 = GetComponent<Image>();
        shell3 = GetComponent<Image>();

        shell1.enabled = false;
        shell2.enabled = false;
        shell3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score.stars == 3)
        {
            shell1.enabled = true;
            shell2.enabled = false;
            shell3.enabled = false;
        }

        else if (score.stars == 2)
        {
            shell1.enabled = false;
            shell2.enabled = true;
            shell3.enabled = false;
        }
        else if (score.stars == 1)
        {
            shell1.enabled = false;
            shell2.enabled = false;
            shell3.enabled = true;
        }
        else
        {
            shell1.enabled = false;
            shell2.enabled = false;
            shell3.enabled = false;
        }

    }
}