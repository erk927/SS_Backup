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
    [SerializeField] private float fireDelay = 1f;
    private Transform barrel;
    private AudioSource shot;
    public AudioClip reload;
    public AudioClip shoot;
    private bool canFire = true;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
        shot = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canFire){
            canFire = false;
            shot.PlayOneShot(shoot);
            StartCoroutine(FireBullet(barrel));
            
        }
    }

    IEnumerator FireBullet(Transform barrel){
        for (int i = 0; i < bulletCount; i++){
            Quaternion randomRot = Random.rotation;
            GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
            bullet.transform.rotation = Quaternion.RotateTowards(bullet.transform.rotation, randomRot, spread);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(bullet.transform.right * bulletSpeed, ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(0.2f);
        shot.PlayOneShot(reload);
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
        // transform.eulerAngles = new Vector3(0, 0, 45);
    }
}
