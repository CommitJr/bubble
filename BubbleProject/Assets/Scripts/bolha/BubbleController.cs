using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BubbleController : MonoBehaviour
{
    #region SCOPE
    private int force;
    private float speedLimit;
    private int health;
    private bool _hasHit;
    private bool _isDead;
    private Transform target;
    private Vector2 direction;
    private Rigidbody2D rigidBody2D;
    private Collider2D touchCollider;
    private Animator animator;
    private PlayerController playerController;
    private GeneralFunctions generalFunctions;

    [SerializeField] private GameObject death;
    #endregion

    #region START
    void Start()
    {
        DefineStart();
    }
    private void DefineStart()
    {
        force = 120;
        speedLimit = 2.5f;
        _hasHit = false;
        _isDead = false;
        if (SceneManager.GetActiveScene().buildIndex >= 8)
        {
            target = GameObject.FindGameObjectWithTag("LossControl").GetComponent<Transform>();
        }
        

        touchCollider = GameObject.FindWithTag("PlayerController").GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();

        playerController = GameObject.FindWithTag("PlayerController").GetComponent<PlayerController>();
        generalFunctions = GameObject.FindWithTag("PlayerController").GetComponent<GeneralFunctions>();
    }
    #endregion

    void FixedUpdate()
    {
        SpeedController();

        if (!_isDead && SceneManager.GetActiveScene().buildIndex >= 7)
        {
            HealthCheck();
        }
    }
  

    #region SPEED
    private void SpeedController()
    {
        SpeedXAxis();
        SpeedYAxis();
    }

    private void SpeedXAxis()
    {
        if (GetComponent<Rigidbody2D>().velocity.x > speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speedLimit, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (GetComponent<Rigidbody2D>().velocity.x < -speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speedLimit, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    private void SpeedYAxis()
    {
        if (GetComponent<Rigidbody2D>().velocity.y > speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speedLimit);
        }

        if (GetComponent<Rigidbody2D>().velocity.y < -speedLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -speedLimit);
        }
    }
    #endregion

    #region COLLISION
    void OnTriggerEnter2D(Collider2D foreignObject)
    {
        AnimationController(foreignObject);

        if (foreignObject.gameObject.tag == "LossControl")
        {
            Debug.Log("Preparando para o fim");
            generalFunctions.GoToEnd();
            Invoke("move2End", 0.01f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.gameObject.tag);

        #region colisao fatal
        if (collision.collider.gameObject.tag == "Dentes" || collision.collider.gameObject.tag == "Pedras"
            || collision.collider.gameObject.tag == "Helice" || collision.collider.gameObject.tag == "oleo")
        {
            playerController.SetHealth(0);
        }
        #endregion

        #region colisão torpedo
        if (collision.collider.gameObject.tag == "Torpedo")
        {
            playerController.SetHealth(0);
        }
        #endregion

        #region colisao normal
        else if (collision.collider.gameObject.tag == "Corpo")
        {
            playerController.SetHealth(playerController.GetHealth() - 1);
        }
        #endregion

        #region troca de fase

        else if (collision.gameObject.tag == "End" && !_hasHit)
        {
            Debug.Log("UI");
            generalFunctions.Win();

            _hasHit = true;
        }


        #endregion

    }
    #endregion

    private void AnimationController(Collider2D foreignObject)
    {
        if (foreignObject.gameObject.CompareTag("PlayerController"))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = new Vector2(transform.position.x - touchPosition.x, transform.position.y - touchPosition.y).normalized;

            if (direction.x > 0)
            {
                AnimationXAxis();
            }

            if (direction.x < 0)
            {
                AnimationYAxis();
            }

            GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
    }

    private void AnimationXAxis()
    {
        animator.SetBool("Toque x", true);
        animator.SetBool("Toque y", false);
    }

    private void AnimationYAxis()
    {
        animator.SetBool("Toque x", false);
        animator.SetBool("Toque y", true);
    }

    public void DisableToque()
    {
        animator.SetBool("Toque y", false);
        animator.SetBool("Toque x", false);
    }



    private void Move2End()
    {
        direction = (target.position - transform.position);

        direction = direction.normalized;
        direction *= 1;
        rigidBody2D.velocity = direction;
    }

    private void DeathAnimation()
    {
        Instantiate(death, transform.position, transform.rotation);

        gameObject.SetActive(false);

        Debug.Log(_isDead);

        Invoke("defeatTime", 0.99f);
    }

    #region DEATH
    private void defeatTime()
    {
        generalFunctions.Defeat();
        Destroy(GameObject.FindWithTag("death"));
    }
    #endregion

    private void HealthCheck()
    {
        if (playerController.GetHealth() <= 0 && !_isDead)
        {
            _isDead = true;
            DeathAnimation();

        }
    }


}
