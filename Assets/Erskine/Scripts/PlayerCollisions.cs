using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    //Data Fields
    private WeaponSwap wSwap;
    
    private void Start() {
        wSwap = gameObject.GetComponentInChildren<WeaponSwap>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        GameObject collidedWith = other.gameObject;

        //Equip weapon on contact and remove from ground
        if (collidedWith.layer == 11){//Weapon layer
            Destroy(collidedWith);
            wSwap.checkTag(collidedWith.tag);
        }
    }
}
