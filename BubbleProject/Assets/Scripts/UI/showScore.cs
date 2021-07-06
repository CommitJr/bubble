using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    [SerializeField]
    private Image shell1;
    private contadorPontuacao score;
    // Start is called before the first frame update
    void Start()
    {
        shell1.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (score.stars == 3)
            shell1.enabled = true;
    }
}
