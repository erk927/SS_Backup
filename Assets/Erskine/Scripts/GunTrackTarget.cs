using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTrackTarget : MonoBehaviour
{

    //Child objects Weapon sprite
    private SpriteRenderer pistol;
    // private Transform weapon;

    // Update is called once per frame
    void Update()
    {
        // weapon = gameObject.transform.GetChild(0);
        pistol = gameObject.GetComponentInChildren<SpriteRenderer>();
        float angle = gameObject.GetComponentInParent<PlayerDirection>().angle;
        
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
}
