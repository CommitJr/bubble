 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bolha : MonoBehaviour
{

    public GameObject tcena;

    trocacena scripttcena;
    loadScenes restart;

    [SerializeField] contadorPontuacao score;

    [SerializeField] private Animator animator;
    [SerializeField] private Image[] lives;

    public int level = 1;
    public int health = 3;
    public int world = 1;

    [SerializeField] public int numFases;

    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject DefeatUI;
    [SerializeField] private GameObject death;

    void Start()
    {
        scripttcena = tcena.GetComponent<trocacena>();
        
        animator = GetComponent<Animator>();
        playerData data = saveSystem.LoadPlayer();
        if(restart == false)
        {
            level = data.level;
            health = data.health;
            world = data.world;
        }
        else
        {
            level = data.level;
            world = data.world;
        }
        

    /*    Vector2 position;
        position.x = data.position[0];
        position.y = data.position[1];
        transform.position = position;
    */
    }

    void Update()
    {
        
        print(health);
        // live counter
        switch (health)
        {
            case 3:
                lives[2].enabled = true;
                lives[1].enabled = true;
                lives[0].enabled = true;
                break;
            case 2:
                lives[2].enabled = true;
                lives[1].enabled = false;
                lives[0].enabled = false;
                break;
            case 1:
                lives[2].enabled = true;
                lives[1].enabled = false;
                lives[0].enabled = false;
                break;
            case 0:
                lives[2].enabled = false;
                lives[1].enabled = false;
                lives[0].enabled = false;
                Instantiate(death, transform.position, transform.rotation);
                gameObject.SetActive(false);
                Invoke("defeatTime", 0.99f);
                break;
        }
    }

    void defeatTime() {
        DefeatUI.SetActive(true);
    }

    #region colisoes  
    public void OnCollisionEnter2D(Collision2D collision)
    {
        #region colisao fatal
        if (collision.gameObject.tag == "Dentes")
        {

         //   animator.SetTrigger("estoura");
            print("bolha estourou");
       //     StartCoroutine(Aguarde());
            health = 0;
        }
        #endregion

        #region colisao normal
        else if (collision.gameObject.tag == "Corpo")
        {
            print("bolha perdeu uma vida");
            health--;
        }
        #endregion

        #region troca de fase

        else if (collision.gameObject.tag == "end")
        {
            print("chegou ao fim da fase");

            WinUI.SetActive(true);
            Time.timeScale = 0f;
        /*    PlayerPrefs.SetInt("levelCompleted", level);
            PlayerPrefs.Save();
        */
            level ++;
            if(level == numFases)
            {
                world++;
            }
            saveSystem.SavePlayer(this);

            /*if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("levelCompleted"))
            {
                PlayerPrefs.SetInt("levelCompleted", SceneManager.GetActiveScene().buildIndex);
                PlayerPrefs.Save();
            }*/

        }
        #endregion
    }

  /*  IEnumerator Aguarde()
    {
        yield return new WaitForSeconds(3.0f);
        scripttcena.IniciaTransicao(0);
        scripttcena.MudaCena();
    }*/

    #region colisao eletrica
    void OnParticleCollsion(GameObject other)
    {
        print("acertou a bolha");

        //   GameObject.Find("Player").GetComponent(bolhaController).enabled = false;
        // GetComponent(bolhaController).enabled = false;

    }
    #endregion

    #endregion

   
}

