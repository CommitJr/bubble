using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundLoop : MonoBehaviour
{
    [SerializeField] private MeshRenderer mesh;
    [SerializeField] private GameObject player;

    // Update is called once per frame
    void Update()
    {
        mesh.material.mainTextureOffset = new Vector2(player.transform.position.x/20, player.transform.position.y/20);
    }
}
