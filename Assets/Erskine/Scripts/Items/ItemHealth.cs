using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHealth : MonoBehaviour
{

    private PlayerDamage playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerDamage>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(14, 13);//enemies
        Physics2D.IgnoreLayerCollision(14, 10);//bullets

        playerHealth.restoreHealth();
        Destroy(gameObject);
    }
}
