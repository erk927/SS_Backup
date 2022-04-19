using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    //Perhaps attach to an 'invisible' object on tile map and allocate position from there?

    //gameObject[3] enemies;//How does Erk put weapons/etc in arrays?

    // Start is called before the first frame update
    void Start()
    {
        //get Enemies for map and add to the gameObject array enemies
        //InvokeRepeating("spawn", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void spawn()
    {
        var random = new Random();
        int num = random.Next(0, 100);
        if(num >= 90)//Spawn Elite
        {
            Instantiate(enemies[2], transform.position, transform.position.y);
        }
        if(num < 90 && num >= 60)//Spawn 'Spitter'
        {
            Instantiate(enemies[1]);
        }
        else //Spawn regular
        {
            Intantiate(enemies[0]);//Should be Instantiate(enemyObject, spawnPosition);
        }
    }*/
}
