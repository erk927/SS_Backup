using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRC : MonoBehaviour
{

    //Attributes
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private LineRenderer lr;
    [SerializeField] private float fireDelay = 1f;
    private Transform barrel;
    private bool canFire = true;

    private AudioSource shot;
    public AudioClip reload;
    public AudioClip shoot;

    private void Start() {
        barrel = this.gameObject.transform.GetChild(0);
        shot = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetButton("Fire1") && canFire){
            CreateLaser();
        }
        else if ((Input.GetButtonUp("Fire1")) && canFire){
            canFire = false;
            shot.PlayOneShot(shoot);
            StartCoroutine(FireWeapon());
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

    IEnumerator FireWeapon(){
        lr.enabled = false;
        GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
        shot.PlayOneShot(reload);
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
    }
}
