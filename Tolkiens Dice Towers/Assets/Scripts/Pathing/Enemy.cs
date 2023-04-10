using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Waypoints Wpoints;

    private int waypointIndex;

    void Start()
    {
        Waypoints[] Waypoints = GameObject.FindWithTag("Waypoints").GetComponents<Waypoints>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
        {
            if(waypointIndex < Wpoints.waypoints.Length - 1)
            {
                waypointIndex ++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}