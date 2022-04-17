using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstFire : MonoBehaviour
{

    //Data Fields
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int burstSize = 0;
    [SerializeField] private float burstSpeed;
    [SerializeField] private float fireDelay;
    private Transform barrel;
    private AudioSource shot;
    private bool canFire = true;

    // Start is called before the first frame update
    void Start(){
        barrel = this.gameObject.transform.GetChild(0);
        shot = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Fire1")) && canFire){
            canFire = false;
            StartCoroutine(fire());
        }
    }

    IEnumerator fire(){
        int count = 0;
        while (count < burstSize){
            GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
            shot.Play();
            count++;
            yield return new WaitForSeconds(burstSpeed);
        }
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
    }
}
