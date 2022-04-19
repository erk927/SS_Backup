using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;//important

public class GenericBullet : MonoBehaviour
{

    //Data Fields
    private float destroyTime = 1f;
    public GameObject impactEffect;
    private Camera cam;

    private void Start() {
        Object.Destroy(gameObject, destroyTime);
        Physics2D.IgnoreLayerCollision(10,10); //Stops bullets colliding w/ eachother
        Physics2D.IgnoreLayerCollision(10,11); // player
        Physics2D.IgnoreLayerCollision(10,12); // weapons

        cam = FindObjectOfType<Camera>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
        if (other.gameObject.layer == 13){
            CameraShaker.Instance.ShakeOnce(4f, 2f, 0.1f, 1f);
            GameObject blood = Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(blood, 0.5f);
        }
    }
}
