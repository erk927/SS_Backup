using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBob : MonoBehaviour
{
    // //Data Fields
    [SerializeField]private float range = 0.1f; //range item bobs between
    [SerializeField]private float intensity = 5f; //speed item bobs at
    [SerializeField]private float speed = 80f; //item rotation speed
    [SerializeField]private float lifeSpan = 6f;
    private float originalYPos;
    private float newYPos;

    void Start()
    {
        originalYPos = transform.position.y;
        Destroy(gameObject, lifeSpan);
    }

    void Update()
    {
        //Bobs item up and down
        newYPos = originalYPos + (Mathf.Sin(Time.time * intensity) * range);
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

        //Rotates item around y-axis
        transform.RotateAround(transform.position, Vector3.up, (Time.deltaTime * speed));
    }
}
