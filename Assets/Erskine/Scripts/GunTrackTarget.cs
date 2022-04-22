using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTrackTarget : MonoBehaviour
{

    //Child objects Weapon sprite
    private SpriteRenderer pistol;
    private float angle;
    private GameObject reticle;
    // private Transform weapon;

    private void Start() {
        reticle = GameObject.FindWithTag("reticle");
    }

    // Update is called once per frame
    void Update()
    {
        // weapon = gameObject.transform.GetChild(0);
        pistol = gameObject.GetComponentInChildren<SpriteRenderer>();
        angle = AngleBetweenPoints(transform.position, reticle.transform.position);
        
        // Flips gun sprite when looking left
        if (pistol != null){ 
            if (angle > 90 && angle < 270) { pistol.flipY = true;}
            else { pistol.flipY = false; }
        }

        // if (weapon != null){ 
        //     if (angle > 90 && angle < 270) { 
        //         weapon.transform.rotation = Quaternion.Euler(weapon.rotation.x, 180, weapon.rotation.z);
        //     }
        //     else { 
        //         Quaternion.Euler(weapon.rotation.x, 0,weapon.rotation.z); 
        //     }
        // }


        //Rotates gun around player
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
    }

    public float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg + 180;
    }
}
