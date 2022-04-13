using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    
    [SerializeField] private Camera mainCamera;
    public Vector3 mouseWorldPosition;

    // Update is called once per frame
    void Update()
    {
        mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = transform.position.z;
        transform.position = mouseWorldPosition;
    }

    // Function
    public float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg + 180;
     }
}

    /*Explanation
        This works by getting the mouses position in the cameras viewspace. We attach the camera in the inpsector.
        This returns a vector3 which we can then assign to the object this script is attached to. 
    */

    /* Note
        -Add camera to script in inspector view
        -Add script to object you want to to be at that position
    */
