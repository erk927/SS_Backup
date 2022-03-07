using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActiveTracking : MonoBehaviour//Current state is for a single player and enemy, need to set melee distance collision in seperate script(?)
{
    public float speed = 3f;//Enemy speed, shoud be able to modify it with a difficulty setting
    public float lerpSpeed = 0.3f;
    private Rigidbody2D enemy;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();//Find the enemy object
        player = GameObject.Find("Player");//FInd the player object
    }

    // Update is called once per frame
    void Update()
    {
        //Trying something simple
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        /*//This code needs to be tested and should be generic as possible
        if (player.transform.position.y > enemy.transform.position.y && player.transform.position.x < enemy.transform.position.x) //Is player above and left of enemy?
        {
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);


            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.left * speed, lerpSpeed * Time.deltaTime);
        }
        else if (player.transform.position.y > enemy.transform.position.y && player.transform.position.x > enemy.transform.position.x)//Player above and to the right
        {
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);
            
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.right * speed, lerpSpeed * Time.deltaTime);
        }
        else if (player.transform.position.y < enemy.transform.position.y && player.transform.position.x < enemy.transform.position.x)//Player below and left of enemy
        {
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.down * speed, lerpSpeed * Time.deltaTime);
 
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.left * speed, lerpSpeed * Time.deltaTime);
        }
        else if (player.transform.position.y < enemy.transform.position.y && player.transform.position.x > enemy.transform.position.x)//Player below right
        {
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.down * speed, lerpSpeed * Time.deltaTime);
            
            enemy.velocity = Vector2.zero;
            enemy.velocity = Vector2.Lerp(enemy.velocity, Vector2.right * speed, lerpSpeed * Time.deltaTime);
        }*/
    }
}
