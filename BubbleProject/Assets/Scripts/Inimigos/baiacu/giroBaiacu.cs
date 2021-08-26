using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroBaiacu : MonoBehaviour
{
    [SerializeField] private GameObject baiacu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Gira();
    }

    private void Gira()
    {
        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, transform.eulerAngles.z + 0.5f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (baiacu.transform.tag != "Corpo") 
            {
                baiacu.transform.tag = "Corpo";
            }
            else
            {
                baiacu.transform.tag = "Baiacu";
            }
        }
        else
        {
            baiacu.transform.tag = "Baiacu";
        }
    }
}
