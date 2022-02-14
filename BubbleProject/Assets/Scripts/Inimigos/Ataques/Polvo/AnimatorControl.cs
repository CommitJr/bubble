using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    [SerializeField] private Animator animatorControl;
    private Transform player;
    bool _canAttack;
    [SerializeField] private Transform centro;
    private Vector2 direction;
    private PlayerController playerController;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        if (!animatorControl) animatorControl = GetComponent<Animator>();
        _canAttack = true;
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (_canAttack)
        {
            if (Vector2.Distance(centro.position, player.position) < 5)
            {
             //   Debug.Log("bolha na area");
                animatorControl.SetBool("_toAttack", true);
           //     Debug.Log("preparando para o ataque");
                StartCoroutine(Change(animatorControl.GetCurrentAnimatorStateInfo(0).length));
             //   Debug.Log("realizando o ataque");
                animatorControl.SetBool("_canAttack", true);
            }
        }
    }

    private IEnumerator Change(float _delay = 0)
    {
        yield return new WaitForSeconds(_delay);
    }

    public void StopAttack()
    {
        _canAttack = false;
        Debug.Log(_canAttack);
        animatorControl.SetBool("_toAttack", false);
        animatorControl.SetBool("_canAttack", false);
        playerController.KillPlayer();
    }
    
  
}
