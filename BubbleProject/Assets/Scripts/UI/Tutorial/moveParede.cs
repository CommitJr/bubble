using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveParede : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject[] tutorial;
    [SerializeField] private GameObject inter;
    [SerializeField] private PlayerController playerController;
    private int contTutorial = 0;

    // Update is called once per frame
    void Update()
    {
        if (contTutorial < 2)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y);

            if (contTutorial == 0 && (((float)gameObject.transform.position.x) - ((float)player.transform.position.x)) > 8)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + (8 - (((float)gameObject.transform.position.x) - ((float)player.transform.position.x))), player.transform.position.y);
            }
            if (contTutorial == 1 && (((float)gameObject.transform.position.x) - ((float)player.transform.position.x)) < -8)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + (-8 - (((float)gameObject.transform.position.x) - ((float)player.transform.position.x))), player.transform.position.y);
            }
        }
        else 
        {
            gameObject.transform.position = new Vector2(player.transform.position.x, gameObject.transform.position.y);

            if (contTutorial == 2 && (((float)gameObject.transform.position.y) - ((float)player.transform.position.y)) < -10)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + (-10 - (((float)gameObject.transform.position.y) - ((float)player.transform.position.y))));
            }

            if (contTutorial == 3)
            {
                if (inter.active == true)
                {
                    if ((((float)gameObject.transform.position.y) - ((float)player.transform.position.y)) < 10)
                    {
                        gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y + 10);
                    }
                } else
                {
                    if ((((int)gameObject.transform.position.y) - ((int)player.transform.position.y)) > 10)
                    {
                        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + (10 - (((float)gameObject.transform.position.y) - ((float)player.transform.position.y))));
                    }
                }
            }
        }     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            contTutorial++;

            switch (contTutorial)
            {
                case 1:
                gameObject.transform.position = new Vector2(gameObject.transform.position.x - 10, gameObject.transform.position.y);
                tutorial[contTutorial-1].SetActive(false);
                tutorial[contTutorial].SetActive(true);
                break;
            case 2:
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 10);
                    gameObject.transform.Rotate(new Vector3(0, 0, 90));
                    tutorial[contTutorial - 1].SetActive(false);
                    tutorial[contTutorial].SetActive(true);
                break;
            case 3:
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y + 10);
                tutorial[contTutorial - 1].SetActive(false);
                tutorial[contTutorial].SetActive(true);
                break;
            case 4:
                gameObject.SetActive(false);
                tutorial[contTutorial - 1].SetActive(false);
                tutorial[contTutorial].SetActive(true);
                break;
            }

            playerController.enabled = false;
    }
}
