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

    public int level5 = 1;
    public int level4 = 1;
    public int level3 = 1;
    public int level2 = 1;
    public int level1 = 1;

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
            level5 = data.level5;
            level4 = data.level4;
            level3 = data.level3;
            level2 = data.level2;
            level1 = data.level1;

            health = data.health;

            world = data.world;
        }
        else
        {
            level5 = data.level5;
            level4 = data.level4;
            level3 = data.level3;
            level2 = data.level2;
            level1 = data.level1;

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
        Destroy(GameObject.FindWithTag("death"));
    }

    #region colisoes  
    public void OnCollisionEnter2D(Collision2D collision)
    {
        #region colisao fatal
        if (collision.gameObject.tag == "Dentes")
        {
            health = 0;
        }
        #endregion

        #region colisao normal
        else if (collision.gameObject.tag == "Corpo")
        {
            health--;
        }
        #endregion

        #region troca de fase

        else if (collision.gameObject.tag == "end")
        {
            print("chegou ao fim da fase");

            WinUI.SetActive(true);
            Time.timeScale = 0f;

            // magica, não mexer

            switch (world)
            {
                case 5:
                    level5++;
                    break;
                case 4:
                    level4++;
                    break;
                case 3:
                    level3++;
                    break;
                case 2:
                    level2++;
                    break;
                case 1:                     // camada 5
                    level1++;
                    break;
            }

            if (level1 == numFases)
            {
                world++;
            }
            if (level2 == numFases)
            {
                world++;
            }
            if (level3 == numFases)
            {
                world++;
            }
            if (level4 == numFases)
            {
                world++;
            }
            if (level5 == numFases)
            {
                world++;

            }
            saveSystem.SavePlayer(this);


        }
        #endregion

        

    }
    #region colisao eletrica
    public void OnParticleCollsion(GameObject other)
    {
        if (other.gameObject.tag == "ataque")
        {
            print("acertou a bolha");
        }

        //   GameObject.Find("Player").GetComponent(bolhaController).enabled = false;
        // GetComponent(bolhaController).enabled = false;

    }
    #endregion

    #endregion

   
}

