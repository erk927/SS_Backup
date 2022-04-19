using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActiveTracking : MonoBehaviour//Current state is for a single player and enemy, need to set melee distance collision in seperate script(?)
{
    public float speed = 1f;//Enemy speed, shoud be able to modify it with a difficulty setting
    public float lerpSpeed = 0.3f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");//FInd the player object
    }

    // Update is called once per frame
    void Update()
    {
        //Trying something simple
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
