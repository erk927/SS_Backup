using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackPlayer : MonoBehaviour
{

    // Variables 
    //[SerializeField] private Camera mainCamera;
    public Transform player;
    
    private void Start() {
        Camera.main.orthographicSize = 5f;//Reduces camera size
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myV = transform.position;//To maintain camera's z position
        //Tracks player position and updates camera
        transform.position = new Vector3(player.position.x, player.position.y, myV.z);
        
    }
}
