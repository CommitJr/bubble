using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class passaFase : MonoBehaviour
{
    [SerializeField]  public int next;
    // Start is called before the first frame update
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("trocou a fase");
            SceneManager.LoadScene(next);
            if (next > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", next);
            }
        }
    }
}
