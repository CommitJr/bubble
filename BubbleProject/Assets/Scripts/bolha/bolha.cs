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

    bool hasHit = false;

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

    void defeatTime() {
        DefeatUI.SetActive(true);
        Destroy(GameObject.FindWithTag("death"));
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

        else if (collision.gameObject.tag == "end" && !hasHit)
        {
            WinUI.SetActive(true);

            // o nível atual é diferente do nível salvo? ou é igual ao primeiro nível? --> tentativa de evitar o burlamento
            if(level != level || level == 1)
            {
                level++;
            // chegou no final da fase de cada camada? atualiza o mundo e "zera" o nivel pra outra contagem
                if(level == numFases)
                {
                    world++;
                    level = 1;
                }
            }



            saveSystem.SavePlayer(this);
            hasHit = true;
        }
        #endregion

        

    }
    #endregion
}

