using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Rifle : MonoBehaviour
{
    private float destroyTime = 1f;
    public int damage = 4;

    private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(10,10); //Stops bullets colliding w/ eachother
        Destroy(gameObject);
    }
    
    private void Start() {
        Object.Destroy(gameObject, destroyTime);
    }
}
