using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class trocacena : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int cenaIndice;
    
    public void IniciaTransicao(int cenaIndiceSelecionada)
    {
        cenaIndice = cenaIndiceSelecionada;
        animator.SetTrigger("inicia");
    }

    public void MudaCena(){
        SceneManager.LoadScene(cenaIndice);
    }

    public void Sair(){
        Application.Quit();
    }
}