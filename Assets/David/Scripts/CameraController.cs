using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position.x = target.transform.position.x;
        //transform.position.y = target.transform.position.y;
        float xPos = target.transform.position.x;
        float yPos = target.transform.position.y;
        Vector3 newPos = new Vector3(xPos,yPos,-10);
        transform.position = newPos;
    }
}

