using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float moveSpeed = 2f;

    private int waypointIndex = 0;
    private bool canGoBack = false;
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
        Wayback();
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1 && !canGoBack)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            if (waypointIndex > waypoints.Length - 1)
            {
                canGoBack = true;
            }
        }
    }

    private void Wayback()
    {
        if (canGoBack)
        {
            if (waypointIndex <= waypoints.Length || waypointIndex >= waypoints.Length - 2)
             {
               transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex-1].transform.position, moveSpeed * Time.deltaTime);
               if (transform.position == waypoints[waypointIndex-1].transform.position)
               {
                   waypointIndex -= 1;
               }

               if (waypointIndex < waypoints.Length - 2 )
               {
                   canGoBack = false;
               }

            }
        }
        
    }
}
