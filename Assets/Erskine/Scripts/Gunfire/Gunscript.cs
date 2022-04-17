using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunscript : MonoBehaviour
{
        
    //Attributes
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    private AudioSource pistolShot;
    private Transform barrel;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
        pistolShot = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            FireBullet();
            pistolShot.Play();
        }
    }

    void FireBullet(){
        GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
        // transform.eulerAngles = new Vector3(0, 0, 45);
    }
}
