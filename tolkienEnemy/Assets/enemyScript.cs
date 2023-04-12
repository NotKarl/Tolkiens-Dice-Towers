using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Engine.AI; //for moving (?)

public class enemyScript : MonoBehaviour
{

    abstract class Enemy
    {

        internal static int count = 0;
        internal int hp = 1;
        internal int ap = 1;
        internal int speed = 1;
        internal bool alive;

        public Enemy()
        {                                                     //constructor
            count++;
            Debug.Log($"Enemy created! There are/is {count} enemie(s)!");
            alive = true;
            
        }

        public virtual void TakeDamage(int damage)
        {
            hp--;
            Debug.Log($"I got {damage} damage!");
            Debug.Log($"I have {hp} hp left!");

            if (hp == 0)    Death();
        }

        public virtual void Death ()
        {
            count--;
            Debug.Log($"Enemy dies! There are/is {count} enemie(s) left!");
            alive = false;

            //death animation, few seconds later enemy object destroyed //different death animation (explosion?) if (lastWaypointIsReached) ?
            //Destroy(gameObject);
        }

        public virtual void Attack ()
        {
            //play attack animation (explosion?);
            //hp of tower - the ap of enemy
            Death();
        }

        public virtual void Walk ()
        {
            //play walk animation
            //move along path with speed

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
        /* while (alive)                   
           {
               if (lastWaypointIsReached)
                  Enemy.Attack();
               else if (hitByTowerShot)
                  Enemy.TakeDamage();
               else 
                  Enemy.Walk(); 
                                           //https://www.youtube.com/watch?v=I3sY3I_f5_o  tut for animation implementation
           }
         */
    }
}
