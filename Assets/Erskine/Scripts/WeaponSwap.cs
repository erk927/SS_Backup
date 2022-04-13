using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    //Data Fields
    [SerializeField]private GameObject[] weapons;//array of weapons
    private GameObject equipped;// Current Weapon

    //Checks the tag of the weapon collided with and equips it
    public void checkTag(string pickedUp){
        for (int i = 0; i < weapons.Length; i++){
            if (weapons[i].tag == pickedUp){
                equipWeapon(i);
                break;
            }
        }
    }

    //Destroys equipped weapon, and equips new one
    private void equipWeapon(int n){
        Destroy(equipped);
        equipped = Instantiate(weapons[n], transform.position, transform.rotation);
        equipped.transform.SetParent(transform);
        //Vector3 spawnPos = weapons[1].transform.position + transform.position;
    }
}
