using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunscript : MonoBehaviour
{
        
    //Attributes
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    private Transform barrel;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)){
            FireBullet();
        }
    }

    void FireBullet(){
        GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
        // transform.eulerAngles = new Vector3(0, 0, 45);
    }
}
