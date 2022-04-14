using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacing : MonoBehaviour
{

    private SpriteRenderer player;
    [SerializeField] private Sprite[] spriteArray;
    [SerializeField] private MousePosition mousePos;
    [HideInInspector] public float angle;


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = mousePos.AngleBetweenPoints(transform.position, mousePos.mouseWorldPosition);
        if (angle > 31 && angle < 150){//up
            player.sprite = spriteArray[0];
        }
        else if (angle > 210.1 && angle < 330){//down
            player.sprite = spriteArray[2];
        }
        else if (angle > 150.1 && angle < 210){//left
            player.sprite = spriteArray[3];
        }else
            player.sprite = spriteArray[1];//right
    }
}
