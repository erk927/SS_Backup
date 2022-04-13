using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericBullet : MonoBehaviour
{

    //Data Fields
    private float destroyTime = 1f;

    private void Start() {
        Object.Destroy(gameObject, destroyTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(10,10); //Stops bullets colliding w/ eachother
        Destroy(gameObject);
    }
}
