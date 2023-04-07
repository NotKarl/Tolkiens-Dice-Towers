using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    abstract class Enemy
    {
        internal static int count = 0;
        internal int hp = 1;
        internal int speed = 1;
        internal int ap = 1;

        public Enemy()
        {                                                     //constructor
            count++;
            Debug.Log($"Enemy created! There are {count} enemie(s)!");
        }

        public virtual void TakeDamage(int damage)
        {
            hp--;
            Debug.Log($"I got {damage} damage!");
            Debug.Log($"I have {hp} hp left!");

            if (hp == 0)
            {                                                    //death
                count--;
                Debug.Log($"Enemy dies! There are {count} enemie(s) left!");
                //death animation start, few seconds later enemy object destroyed
            }
        }
    }

    class Troll : Enemy
    {


    }

    class Ork : Enemy
    {


    }
    // Start is called before the first frame update
    void Start()
    {
        Enemy[] enemies = new Enemy[] {                  //creating enemies
            new Troll(),
            new Ork()
        };

        foreach (Enemy enemy in enemies)                 //check if it works
        {
            enemy.TakeDamage(5);
        }


    }

    // Update is called once per frame
    void Update()
    {
        // if in range of wall -> start attack animation
        // if hp == 0 -> death animation    
        // else -> walk animation, following path
    }
}

