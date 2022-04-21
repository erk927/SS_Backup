using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private int playerHealth = 100;
    private int playerShield = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHealth(int health){
        playerHealth = health;
        Debug.Log("health restored");
        Debug.Log(playerHealth);
    }

    public void setShield(int shield){
        playerShield = shield;
        Debug.Log("Shield activated");
        Debug.Log(playerShield);
    }

    //Collision check for what damage modifier to use
    void OnCollisionEnter2D(Collision2D collision)
    {
        int damage = 1;

        //This should be rewritten to pull from the enemy object itself if/when implemented

        /*gameObject collidedWith = collision.gameObject;

        if (collidedWith.layer == 12)
        {
            playerHealth -= gameObject.damageToPlayer;
        }*/

        if (collision.gameObject.tag == "enemyBasic")//Medium damage
        {
            //if(floor(currentScore/1000) > 0) increase playerdamage += 10*currentScore/1000;
            if(playerShield > 0)
            {
                damageShield(damage*10);
            }
            else damagePlayer(damage * 10);
            //Debug.Log(playerHealth);
        }
        if (collision.gameObject.tag == "enemyRanged")//Small damage
        {
           if(playerShield > 0)
            {
                damageShield(damage*10);
            }
            else damagePlayer(damage * 10);
        }
        if (collision.gameObject.tag == "enemyElite")//Full damage
        {
            if(playerShield > 0)
            {
                damageShield(damage*10);
            }
            else damagePlayer(damage * 10);
        }
        //If health drops to/below 0, enemy is removed
        if (playerHealth <= 0)
        {
            Time.timeScale = 0;
        }
    }

    //Damage shield instead of player
    void damageShield(int damage)
    {
        playerShield -= damage;
        Debug.Log(playerShield);
    }

    //Damage player
    void damagePlayer(int damage)
    {
        playerHealth -= damage;
        Debug.Log(playerHealth);
    }
}
