using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampiro : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private RaycastHit2D hit;
    private Transform player;
    [SerializeField] private LayerMask mask;
    private float time;
    private Vector3 pointPosition;
    private bool canAttack;
    [SerializeField] float maxDistance;
    private PlayerController playerController;
    private Vector2 direction;
    [SerializeField] private Transform center;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        time = Time.deltaTime;
        pointPosition = center.position;
        canAttack = false;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = true;

       
        direction = new Vector2(player.position.x - center.position.x, player.position.y - center.position.y).normalized;
        playerController = GameObject.FindGameObjectWithTag("PlayerController").GetComponent<PlayerController>();
    }

    void Update()
    {
        Attack();
    
    }

    private void Attack()
    { 

        float distance = Vector2.Distance(pointPosition, center.position);

        if(distance < maxDistance)
        {
             hit = Physics2D.Raycast(center.position, direction, distance, mask);


             if (hit)
             {
                    if(hit.collider.gameObject.tag == "BolhaRastreio")
                    {

                        playerController.GetComponent<PlayerController>().SetHealth(0);
                    }
             }

             if (canAttack)
             {
                Vector3 desiredPosition = direction * 10;
                if (Vector2.Distance(pointPosition, center.position + desiredPosition) > 1)
                {
                    
                    pointPosition = Vector3.Lerp(pointPosition, center.position + desiredPosition, time );
                    lineRenderer.SetPosition(0, center.position);
                    lineRenderer.SetPosition(1, pointPosition);
                }
                else
                {
                    canAttack = false;
                }
                        
             }
            else
            {
                if (Vector2.Distance(pointPosition, center.position) > 1)
                {
                    pointPosition = Vector3.Lerp(pointPosition, center.position, time);
                    lineRenderer.SetPosition(0, center.position);
                    lineRenderer.SetPosition(1, pointPosition);
                }
                else
                {
                    canAttack = true;
                }
            }
            //   lingua.position = pointPosition;
        }

    }
}
