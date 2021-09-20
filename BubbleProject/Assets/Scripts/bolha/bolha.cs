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
    public int level5 = 1;
    public int level4 = 1;
    public int level3 = 1;
    public int level2 = 1;
    public int level1 = 1;

    public int world = 1;

    public int health = 3;

    [SerializeField] private int numFases;

    private GameObject cineMachine;

    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject DefeatUI;
    [SerializeField] private GameObject death;

    bool hasHit = false;

    void Start()
    {
        Time.timeScale = 1f;

        scripttcena = tcena.GetComponent<trocacena>();
        animator = GetComponent<Animator>();

        playerData data = saveSystem.LoadPlayer();

        cineMachine = GameObject.FindGameObjectWithTag("cineMachine");

        if (restart == false)
        {

            level = data.level;
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
            level = data.level;
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
                lives[1].enabled = true;
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

    void defeatTime()
    {
        DefeatUI.SetActive(true);
        Destroy(GameObject.FindWithTag("death"));
    }

    private void atualiza()
    {
        WinUI.SetActive(true);

        if (SceneManager.GetActiveScene().buildIndex - 3 > level)
        {
            switch (world)
            {
                case 5:
                    level5++;
                    level++;
                    break;
                case 4:
                    level4++;
                    level++;
                    break;
                case 3:
                    level3++;
                    level++;
                    break;
                case 2:
                    level2++;
                    level++;
                    break;
                case 1:                     // camada 5
                    level1++;
                    level++;
                    break;
            }

            if (level1 == numFases)
            {
                level = 1;
                world++;
            }
            if (level2 == numFases)
            {
                level = 1;
                world++;
            }
            if (level3 == numFases)
            {
                level = 1;
                world++;
            }
            if (level4 == numFases)
            {
                level = 1;
                world++;
            }
            if (level5 == numFases)
            {
                level = 1;
                world++;

            }
            Debug.Log("atualizou o nivel");
        }

        Debug.Log("level = " + level);
        Debug.Log("index = " + SceneManager.GetActiveScene().buildIndex);

        saveSystem.SavePlayer(this);

        Time.timeScale = 0f;

    }

    private void prepararParaOFim(){

        // entrar linha que impede movimentos do jogador ( ta na enguia )
        // levar a bolha suavemente para o centro
        // subir a bolha -- a gravidade faz isso
        
        cineMachine.SetActive(false);
    }
    #region colisoes  
    public void OnCollisionEnter2D(Collision2D collision)
    {
        #region colisao fatal
        if (collision.gameObject.tag == "Dentes" || collision.gameObject.tag == "Pedras" || collision.gameObject.tag == "Helice")
        {
            health = 0;
        }
        #endregion

        #region colisão torpedo
        if (collision.gameObject.tag == "Torpedo")
        {
            health = 0;
        }
        #endregion

        #region colisao normal
        else if (collision.gameObject.tag == "Corpo")
        {
            health--;
            Debug.Log("bateu no corpo");
        }
        #endregion

        #region troca de fase

        else if (collision.gameObject.tag == "End" && !hasHit)
        {
            atualiza();
            prepararParaOFim();
            hasHit = true;
        }
        #endregion



    }
    #endregion
}

