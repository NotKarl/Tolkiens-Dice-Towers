using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseFortScript : MonoBehaviour
{
    public int HP = 1;
    public UnityEvent onBaseDestroyed;
    void Start()
    {
        
    }
    public void DamageBase(int damage)
    {
        HP =- damage;
        if ( HP <= 0) { onBaseDestroyed.Invoke(); }
    }
}
