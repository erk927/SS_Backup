using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    //Attributes
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float spread;
    [SerializeField] private int bulletCount = 3;
    private Transform barrel;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)){
            FireBullet(barrel);
        }
    }

    void FireBullet(Transform barrel){
        for (int i = 0; i < bulletCount; i++){
            Quaternion randomRot = Random.rotation;
            GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
            bullet.transform.rotation = Quaternion.RotateTowards(bullet.transform.rotation, randomRot, spread);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(bullet.transform.right * bulletSpeed, ForceMode2D.Impulse);
        }
        // transform.eulerAngles = new Vector3(0, 0, 45);
    }
}
