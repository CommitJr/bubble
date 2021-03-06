using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveParede : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject[] tutorial;
    private int contTutorial = 0;

    // Update is called once per frame
    void Update()
    {
        if (contTutorial < 2)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, player.transform.position.y);
        }
        else 
        {
            gameObject.transform.position = new Vector2(player.transform.position.x, gameObject.transform.position.y);
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
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 10);
                tutorial[contTutorial - 1].SetActive(false);
                tutorial[contTutorial].SetActive(true);
                break;
            case 4:
                gameObject.SetActive(false);
                tutorial[contTutorial - 1].SetActive(false);
                tutorial[contTutorial].SetActive(true);
                break;
            }
    }
}
