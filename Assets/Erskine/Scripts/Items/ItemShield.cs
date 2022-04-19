using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShield : MonoBehaviour
{
    private PlayerDamage playerShield;

    // Start is called before the first frame update
    void Start()
    {
        playerShield = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDamage>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(14, 13);//enemies
        Physics2D.IgnoreLayerCollision(14, 10);//bullets

        playerShield.setShield(100);
        Destroy(gameObject);
    }
}
