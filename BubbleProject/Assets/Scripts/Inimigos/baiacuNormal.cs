using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baiacuNormal : MonoBehaviour
{
    [SerializeField] private GameObject baiacu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (baiacu.transform.tag != "Dentes")
            {
                baiacu.transform.tag = "Dentes";
            }
            else
            {
                baiacu.transform.tag = "Baiacu";
            }
        }
        else {
            baiacu.transform.tag = "Baiacu";
        }
    }
}
