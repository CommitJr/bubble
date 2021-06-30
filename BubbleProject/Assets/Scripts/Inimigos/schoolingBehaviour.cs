using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schoolingBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject fish;
    [SerializeField]
    private static int numFish;

    public GameObject[] fishes;
    // Start is called before the first frame update
    void Start()
    {
        fishes = new GameObject[numFish];
        for (int i = 0; i < numFish; i++)
        {
            Vector2 pos = new Vector2(Random.Range(-2, 2), Random.Range(-2, 2));
            fishes[i] = (GameObject)Instantiate(fish, pos, Quaternion.identity);
            print(fishes);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
