using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private double health = 100;
    //public int damageToPlayer = 1;
    private GameObject collidedWith;

    //Pistol | Rifle | Shotgun | Sniper
    private int[] weaponDamage = new int[]{10, 10, 10, 10};

    // Start is called before the first frame update
    void Start(){
        //if(floor(currentScore/1000) > 0) increase enemyhealth += 10*currentScore/1000;
        if (gameObject.tag == "Brute"){
            health *= 2;
        }
        if (gameObject.tag == "RangedEnemy"){
            health *= .75;
        }

    }

    //Collision check for what damage modifier to use
    void OnCollisionEnter2D(Collision2D collision){
        collidedWith = collision.gameObject;

        if (collidedWith.tag == "bulletPistol"){
            health -= weaponDamage[0];
            
        }else if (collidedWith.tag == "bulletRifle"){
            health -= weaponDamage[1];
            
        }else if (collidedWith.tag == "bulletShotgun"){
            health -= weaponDamage[2];
            
        }else if (collidedWith.tag == "bulletSniper"){
            health -= weaponDamage[3];
        }

        // if (collidedWith.tag == "bulletPistol"){
        //     Bullet_Pistol bp = collidedWith.GetComponent<Bullet_Pistol>();
        //     health -= bp.damage;
            
        // }else if (collidedWith.tag == "bulletRifle"){
        //     Bullet_Rifle rp = collidedWith.GetComponent<Bullet_Rifle>();
        //     health -= rp.damage;
            
        // }else if (collidedWith.tag == "bulletShotgun"){
        //     Bullet_Shotgun sp = collidedWith.GetComponent<Bullet_Shotgun>();
        //     health -= sp.damage;
            
        // }else if (collidedWith.tag == "bulletSniper"){
        //     Bullet_Sniper sp = collidedWith.GetComponent<Bullet_Sniper>();
        //     health -= sp.damage;
        // }

        Debug.Log(health);
        //If health drops to/below 0, enemy is removed
        if (health <= 0)
        {
            Destroy(gameObject);
            //score.increaseScore();
        }
    }
}

//This script should be generic enough to be used for all collision checking instances for 'melee' contact from the enemy to the player.
