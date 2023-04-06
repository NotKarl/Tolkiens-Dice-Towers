using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    private Waypoints Wpoints;

    void Start()
    {
        Wpoints = gameObject.FindGameobjectWithTag("Waypoints").GetComponent<Waypoints>();
    }
}
