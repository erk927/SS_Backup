using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTrackTarget : MonoBehaviour
{

    //Child objects Weapon sprite
    private SpriteRenderer pistol;

    // Update is called once per frame
    void Update()
    {
        pistol = gameObject.GetComponentInChildren<SpriteRenderer>();
        float angle = gameObject.GetComponentInParent<PlayerFacing>().angle;
        
        //Flips gun sprite when looking left
        if (pistol != null){ 
            if (angle > 90 && angle < 270) { pistol.flipY = true;}
            else { pistol.flipY = false; }
        }
        //Rotates gun around player
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
    }
}
