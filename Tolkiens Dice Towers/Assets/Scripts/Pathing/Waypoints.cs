using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] waypoints;

    void Awake ()
    {
        waypoints = new Transform[transform.childCount];
        for (int i = 0; i < waypoints.Length; i++)  
        {
            waypoints[i] = transform.GetChild(i);
        }
    }
}
