using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SuperEnemy : MonoBehaviour
{
    //Waypoints:
    public float speed = 4f;
    public Transform target;
    public int waypointIndex;

    //  SuperEnemy script;
    public static int count = 0;
    public int hp = 1;
    public int ap = 1;
    public bool alive;

    public void TakeDamage(int damage)
    {
        hp--;
        Debug.Log($"I got {damage} damage!");

        if (hp > 0)
            Debug.Log($"I have {hp} hp left!");
        else if (hp <= 0)
        {
            Debug.Log($"I have no hp left!");
            Death();
        }
    }

    private void Death()
    {
        count--;
        Debug.Log($"Enemy dies! There are/is {count} enemie(s) left!");
        alive = false;

        //death animation, few seconds later enemy object destroyed //different death animation (explosion?) if (lastWaypointIsReached) ?
        Destroy(gameObject);
        //Destroy(gameObject);
    }

    private void Attack()
    {
        //play attack animation (explosion?);
        //hp of tower - the ap of enemy
        Death();
    }

    public void Walk()
    {
        //play walk animation
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)              //if waypoint is reached
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)                           //if last waypoint(->tower) is reached
        {
            Attack();                                                                   //attack tower
            return;
        }

        waypointIndex++;                                                           //else select next waypoint as target
        target = Waypoints.points[waypointIndex];
    }

    class Troll : SuperEnemy
    {


    }
    class Ork : SuperEnemy
    {


    }


    void Start()
    {
        target = Waypoints.points[0];
        count++;
        Debug.Log($"Enemy created! There are/is {count} enemie(s)!");
        alive = true;

    }


    void Update()
    {
        //if (hit by tower) TakeDamage(x);
        //else 
        Walk();
        //https://www.youtube.com/watch?v=I3sY3I_f5_o  tut for animation implementation
    }
}
