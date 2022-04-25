using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedRotation : MonoBehaviour
{
    //Data Fields
    private GameObject player;
    private Transform barrel;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");//FInd the player object
        barrel = gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update(){
        float angle = AngleBetweenPoints(transform.position, player.transform.position);
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));//Rotate aim
    }

    //Fire projectile from enemyRangedTracking class
    public IEnumerator attack(GameObject pfBullet, float bulletSpeed){
        GameObject bullet = Instantiate(pfBullet, barrel.position, barrel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(barrel.right * bulletSpeed, ForceMode2D.Impulse);
        yield return null;
    }

    public float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg + 180;
    }
}
