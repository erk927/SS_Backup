using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
 //Variables
    [SerializeField] private float speed = 3f;
    [SerializeField] private Rigidbody2D body;

    private Vector2 move;
    public PlayerTrackMouse ptm;

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");   
        move.y = Input.GetAxisRaw("Vertical");   
    }

    private void FixedUpdate() {
        body.MovePosition(body.position + move * speed * Time.fixedDeltaTime);


        Vector3 mWorldPosition = ptm.mouseWorldPosition + Vector3.forward * 10f;

        //Angle between mouse and this object
        float angle = AngleBetweenPoints(transform.position, mWorldPosition);

        //Ta daa
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
    }

    // Function
    float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
//DirectionToFace = destination - source 