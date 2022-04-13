using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    [SerializeField] private float speed = 3f;
    private Rigidbody2D body;
    private Vector2 move;
    
    private void Start() {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");   
        move.y = Input.GetAxisRaw("Vertical");   
    }

    private void FixedUpdate() {
        body.MovePosition(body.position + move * speed * Time.fixedDeltaTime);// moves character
        // Vector3 mWorldPosition = ptm.mouseWorldPosition + Vector3.forward * 10f;
    }
}

//DirectionToFace = destination - source 
