using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    

    //Game begins
    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Every time you press Space barthe health goes down
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
        TakeDamage(20);
        }
    }

    public void TakeDamage (int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
