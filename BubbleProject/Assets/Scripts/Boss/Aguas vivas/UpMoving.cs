using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMoving : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y + 25);
    }
}
