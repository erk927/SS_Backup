using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    //Perhaps attach to an 'invisible' object on tile map and allocate position from there?

    [SerializeField] GameObject[] enemies;//How does Erk put weapons/etc in arrays?
    public float delay = 10f;
    //private int numEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        //get Enemies for map and add to the gameObject array enemies
        InvokeRepeating("spawn", 8.0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        
            int num = Random.Range(0, 100);//Generate random number

            if(num >= 90)//Spawn Elite, Element 2
            {
                Instantiate(enemies[0], gameObject.transform.position, Quaternion.identity);
            }
            if(num < 90 && num >= 60)//Spawn 'Spitter', Element 1
            {
                Instantiate(enemies[1], gameObject.transform.position, Quaternion.identity);
            }
            else //Spawn regular, Element 0
            {
                Instantiate(enemies[2], gameObject.transform.position, Quaternion.identity);
            }
    }
}
