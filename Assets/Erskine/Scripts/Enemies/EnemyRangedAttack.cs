using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedAttack : MonoBehaviour
{
    //Data Fields
    private float destroyTime = 1f;
    private float damage = 10f;

    // Start is called before the first frame update
    private void Awake() {
        Object.Destroy(gameObject, destroyTime);
        Physics2D.IgnoreLayerCollision(10,10); //Stops bullets colliding w/ eachother
        // Physics2D.IgnoreLayerCollision(10,13); // enemies
        Physics2D.IgnoreLayerCollision(10,12); // weapons
        Physics2D.IgnoreLayerCollision(10,14); // Items

    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
        if (other.gameObject.layer == 11){
            Debug.Log("Hit player");
            // GameObject blood = Instantiate(impactEffect, transform.position, transform.rotation);
            // Destroy(blood, 0.5f);
        }
    }

    public float getDamage(){
        return damage;
    }
}
