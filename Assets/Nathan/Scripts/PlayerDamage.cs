using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    //***** Data fields *****
    private float _MAXHEALTH = 100;// FINAL
    private float playerHealth = 0;
    private float playerShield = 0;
    private float damageTaken;//damage from enemy
    private GameObject collidedWith;//object collided with

    // Health and Shield bars \\
    public Slider healthSlider;
    public Slider shieldSlider;
    public GameObject shieldBar;


    // Start is called before the first frame update
    void Start(){
        playerHealth = _MAXHEALTH;

        //Sets up health bar 
        healthSlider = GameObject.FindGameObjectWithTag("healthBar").GetComponent<Slider>();
        healthSlider.maxValue = _MAXHEALTH;
        healthSlider.value = playerHealth;

        //Sets up shield bar
        shieldBar = GameObject.FindGameObjectWithTag("shieldBar");
        shieldSlider = GameObject.FindGameObjectWithTag("shieldBar").GetComponent<Slider>();
        shieldSlider.maxValue = _MAXHEALTH;
        shieldBar.SetActive(false);
    }

    //Restores player health to _MAXHEALTH when called
    public void restoreHealth(){
        playerHealth = _MAXHEALTH;
        healthSlider.value = playerHealth;//refills healthbar
        Debug.Log("Health Restored" + playerHealth);
    }

    //Activates shield and sets it equal to _MAXHEALTH
    public void activateShield(){
        shieldBar.SetActive(true);//Activate shieldBar
        shieldSlider.value = _MAXHEALTH;//refill shieldbar
        playerShield = _MAXHEALTH;
        Debug.Log("Shield activated: " + playerShield);
    }

    //Collision check for what damage modifier to use
    void OnCollisionEnter2D(Collision2D collision){
        collidedWith = collision.gameObject;
        if (collidedWith.layer == 13){//enemy layer
            damageTaken = collidedWith.GetComponent<EnemyDamage>().getDamage();// gets damage from EnemyDamage class
            if (playerShield > 0){//damages shield if active
                damageShield(damageTaken);
            }else
                damagePlayer(damageTaken);//damage player if shield inactive
        }
    }

    //Damage shield if active
    void damageShield(float damage){
        playerShield -= damage;
        shieldSlider.value = playerShield;//ui
        if (playerShield <= 0 ){
            shieldBar.SetActive(false);
        }
        Debug.Log("Shield: " + playerShield);
    }

    //Damage player if shield inactive
    void damagePlayer(float damage){
        playerHealth -= damage;
        healthSlider.value = playerHealth;//ui
        Debug.Log("Health: " + playerHealth);
    }
}

/************************ Original Damage Code *****************************************************/
        // if (collision.gameObject.tag == "enemyBasic")//Medium damage
        // {
        //     //if(floor(currentScore/1000) > 0) increase playerdamage += 10*currentScore/1000;
        //     if(playerShield > 0)
        //     {
        //         damageShield(damage*10);
        //     }
        //     else damagePlayer(damage * 10);
        //     //Debug.Log(playerHealth);
        // }
        // if (collision.gameObject.tag == "enemyRanged")//Small damage
        // {
        //    if(playerShield > 0)
        //     {
        //         damageShield(damage*10);
        //     }
        //     else damagePlayer(damage * 10);
        // }
        // if (collision.gameObject.tag == "enemyElite")//Full damage
        // {
        //     if(playerShield > 0)
        //     {
        //         damageShield(damage*10);
        //     }
        //     else damagePlayer(damage * 10);
        // }
        // //If health drops to/below 0, enemy is removed
        // if (playerHealth <= 0)
        // {
        //     Time.timeScale = 0;
        // }