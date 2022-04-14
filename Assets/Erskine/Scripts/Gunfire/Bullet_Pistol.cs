using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Pistol : MonoBehaviour
{
    private float destroyTime = 1f;
    public int damage = 10;

    private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(10,10); //Stops bullets colliding w/ eachother
        Destroy(gameObject);
    }
    
    private void Start() {
        Object.Destroy(gameObject, destroyTime);
    }
}
