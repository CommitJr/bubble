using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFaseTeste : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y + 25, gameObject.transform.position.z);
    }
}
