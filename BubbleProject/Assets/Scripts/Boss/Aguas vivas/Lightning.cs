using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private bool _isDamage;

    void Start()
    {
        _isDamage = false;
    }
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player" && !_isDamage)
        {
            Debug.Log("Eletrocutado");

            playerController.SetHealth(playerController.GetHealth() - 1);
            _isDamage = true;
            Invoke("choque", 3f); 
        }
    }

    void choque()
    {
        _isDamage = false;
    }
}
