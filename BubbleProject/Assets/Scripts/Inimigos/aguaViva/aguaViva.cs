using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aguaViva : MonoBehaviour
{        
    [Header("Condicoes iniciais")]
    [SerializeField] float initialRotZ = 90;
    [SerializeField] float speed;
    [SerializeField] float amplitude;
    [SerializeField] float direction;
    float startingVal = 0;


    [Header("Componente")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private ParticleSystem lightingEfct;
    [SerializeField] private Animator anim;


    [Header("Auxiliares")]
    GameObject bordaEsqBolha = null;
    GameObject bordaDirBolha = null;
    bool canMove = true;
    bool hitPlayer = false;
    bool turnLimiter = false;
    float auxSinTime = 0;
    float hitCD = 1f;
    float auxHitCD = 0;


    void Start() {
        startingVal = transform.position.y;
        auxHitCD = hitCD;
        bordaEsqBolha = GameObject.Find("borda esquerda bolha");
        bordaDirBolha = GameObject.Find("borda direita bolha");
        lightingEfct.Stop();
    }

    // Update is called once per frame
    void FixedUpdate() {        
        if (canMove) {
            Move(); 
            sinMove();                       
        } 
        if (hitCD <= auxHitCD) {
            canMove = true;
            if (hitPlayer) {
                //Debug.Log("HIT");
                rb.velocity = new Vector2(0f,0f);                
                startingVal = transform.position.y;
                hitPlayer = false;
            }            
        } else {
            auxHitCD += Time.deltaTime;
            auxSinTime = 0f;
        }

        Rotation();
        prepareToWallCollision();
        animControll();
    }


    #region MOVEMENT
    public void Move() {
        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
    }
    void sinMove() {        
        var sinRes = Mathf.Sin(auxSinTime * speed);
        transform.position = new Vector3(transform.position.x, startingVal + (sinRes*amplitude), transform.position.z);                    
    }
    void Rotation() {
        if (!turnLimiter) {
            var sinRes = Mathf.Sin(auxSinTime * speed);
            auxSinTime += Time.deltaTime;
            if (direction == 1)
                transform.rotation = Quaternion.AngleAxis(sinRes*-45-initialRotZ, new Vector3(0f, 0f, 1f));
            else
                transform.rotation = Quaternion.AngleAxis(sinRes*45+initialRotZ, new Vector3(0f, 0f, 1f));             
        }
    }
    void prepareToWallCollision() {
        if (bordaDirBolha.transform.position.x + 5 < transform.position.x || bordaEsqBolha.transform.position.x - 5 > transform.position.x) {
            turnLimiter = true;
            transform.rotation = Quaternion.AngleAxis(90*(-direction), new Vector3(0f, 0f, 1f));
        } else {
            turnLimiter = false;
        }
    }
    #endregion


    #region ANIMATION_CONTROLL
    void animControll() {
        // Debug.Log(transform.rotation.z);
        if (Mathf.Abs(transform.rotation.z) < 0.5 || Mathf.Abs(transform.rotation.z) > 0.9) {
            anim.SetBool("PushingWater", true);
        } else {
            anim.SetBool("PushingWater", false);
        }
    }
    #endregion


    #region COLLISION
    void OnTriggerEnter2D (Collider2D collider) {
        if (collider.transform.parent != null && collider.transform.parent.tag == "Player") {
            //Debug.Log("Player morre");
            lightingEfct.Play ();
            ParticleSystem.EmissionModule em = lightingEfct.emission;
            em.enabled = true;
            GameObject.FindWithTag("PlayerController").GetComponent<PlayerController>().SetHealth(0);         
        }        
    }
    void OnCollisionEnter2D (Collision2D collision) {             
        if (collision.collider.transform.parent != null && collision.collider.transform.parent.tag == "Player") { 
            hitPlayer = true;
            canMove = false;                
            auxHitCD = 0f;
            var knockback = new Vector2 (0,0);         
            // Bolha na direita
            if (collision.transform.position.x >= transform.position.x) {
                //Debug.Log("Bolha direita"); 
                knockback.x -= 1; }
            // Bolha na esquerda
            if (collision.transform.position.x <= transform.position.x) {
                //Debug.Log("Bolha esquerda");
                knockback.x += 1; }
            // Bolha em cima
            if (collision.transform.position.y >= transform.position.y) {
                //Debug.Log("Bolha cima");
                knockback.y -= 1; }
            // Bolha em baixo
            if (collision.transform.position.y <= transform.position.y) {
                //Debug.Log("Bolha baixo");
                knockback.y += 1; }
            rb.velocity = knockback;
        } 
        if (collision.transform.tag == "parede" || collision.transform.tag == "Pedras") {
            direction *= -1;
            transform.eulerAngles = new Vector2(0f, 180);
            if (direction == -1) {
                transform.eulerAngles = new Vector2(0f, 0);
            }
        }     
    }
    #endregion
}
