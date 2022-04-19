using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private int playerHealth = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
            playerHealth -= damage * 50;
            Debug.Log(playerHealth);
        }
        if (collision.gameObject.tag == "enemyRanged")//Small damage
        {
            playerHealth -= (damage * 25);
        }
        if (collision.gameObject.tag == "enemyElite")//Full damage
        {
            playerHealth -= damage * 100;
        }
        //If health drops to/below 0, enemy is removed
        if (playerHealth <= 0)
        {
            //load game over, check if score should be saved to high scores(take player name/initials);
            //player.saveScore();
        }
    }
}
