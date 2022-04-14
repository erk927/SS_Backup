using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRC : MonoBehaviour
{

    //Attributes
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private LineRenderer lr;
    private Transform barrel;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)){
            CreateLaser();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0)){
            FireWeapon();
        }
    }

    void CreateLaser(){
        RaycastHit2D hitPoint = Physics2D.Raycast(barrel.position, barrel.right);

        if (hitPoint){
            lr.enabled = true;
            lr.SetPosition(0, barrel.position);
            lr.SetPosition(1, hitPoint.point);
        }
    }

    void FireWeapon(){
        lr.enabled = false;
        GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
