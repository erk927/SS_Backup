using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    //***** Data Fields 
    [SerializeField] private GameObject[] gdWeapons;
    [SerializeField] private GameObject[] gdItems;
    private GameObject collidedWith;
    private float health = 10;// base enemy health
    private float damage = 10;// base damage enemy does

    //Pistol | RifleBurst | Shotgun | Sniper | RifleAuto
    private int[] weaponDamage = new int[]{10, 10, 10, 10, 10};


    // Start is called before the first frame update
    void Start(){
        //These if's scale enemy damage & health with their type
        if (gameObject.tag == "enemyElite"){ health *= 2; damage *= 3; }
        if (gameObject.tag == "enemyRanged"){ health *= .75f; damage *= 2; }
        if (gameObject.tag == "omarion"){ health *= 10; damage *= 5; }

        //Enemies cannot collide with ground items or weapons
        Physics2D.IgnoreLayerCollision(13, 12);
        Physics2D.IgnoreLayerCollision(13, 14);

        //if(floor(currentScore/1000) > 0) increase enemyhealth += 10*currentScore/1000;
    }

    //Returns damage enemy type inflicts
    public float getDamage(){
        return damage;
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

        //Debug.Log(health);

        //If health drops to/below 0, enemy is removed
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Trying to increase score");
            GameObject score = GameObject.FindGameObjectWithTag("score");
            playerScore player = score.GetComponent<playerScore>();
            if(player != null)
            {
                player.increaseScore();
                Debug.Log("Increased score");
            }
            else Debug.Log("score is null");
            
            dropOnDeath();
        }
    }

    //Decides what to 'drop' when enemy dies
    void dropOnDeath()
    {
        int num = Random.Range(0, 100);

        if(num <= 50 && num > 32)//Probability to drop 'Health'
        {
            Instantiate(gdItems[0], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 32 && num > 22)//'Shield'
        {
            Instantiate(gdItems[1], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 22 && num > 15)//'Invincibility'
        {
            Instantiate(gdItems[2], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 15 && num > 12)
        {
            Instantiate(gdWeapons[0], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 12 && num > 9)
        {
            Instantiate(gdWeapons[1], gameObject.transform.position, Quaternion.identity);
        }
        
        if (num <= 9 && num > 6)
        {
            Instantiate(gdWeapons[2], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 6 && num > 3)
        {
            Instantiate(gdWeapons[3], gameObject.transform.position, Quaternion.identity);
        }

        if (num <= 3)
        {
            Instantiate(gdWeapons[4], gameObject.transform.position, Quaternion.identity);
        }
    }
}
