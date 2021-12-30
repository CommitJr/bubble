using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    [SerializeField] private Animator animatorControl;
    private Transform player;

    [SerializeField] private Transform centro;
    private Vector2 direction;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BolhaRastreio").GetComponent<Transform>();
        if (!animatorControl) animatorControl = GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector2.Distance(centro.position, player.position) < 5)
        {
            Debug.Log("bolha na area");
            animatorControl.SetBool("_toAttack", true);
            Debug.Log("preparando para o ataque");
            StartCoroutine(Change(animatorControl.GetCurrentAnimatorStateInfo(0).length));
            Debug.Log("realizando o ataque");
            animatorControl.SetBool("_canAttack", true);
        }
    }

    private IEnumerator Change(float _delay = 0)
    {
        yield return new WaitForSeconds(_delay);
    }
}
