using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedRotation : MonoBehaviour
{
    //Data Fields
    private GameObject player;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");//FInd the player object
    }

    // Update is called once per frame
    void Update(){
        float angle = AngleBetweenPoints(transform.position, player.transform.position);
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));//Rotate aim
    }

    public float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg + 180;
    }
}
