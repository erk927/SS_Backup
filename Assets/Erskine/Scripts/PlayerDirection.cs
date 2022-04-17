using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    //Data Fields **************************************************
    [SerializeField] private MousePosition mousePos;
    [HideInInspector] public float angle;
    private PlayerMovement pm;
    public Animator animator;
    
    private float notIdle = 0;

    // Start is called before the first frame update
    void Start(){
        pm = gameObject.GetComponent<PlayerMovement>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){   
        angle = mousePos.AngleBetweenPoints(transform.position, mousePos.mouseWorldPosition);
        changeDirection();
    }

    //Changes character animation depending on where the mouse cursor is
    public void changeDirection(){
        notIdle = Mathf.Abs(pm.move.y) + Mathf.Abs(pm.move.x);

        if (angle > 31 && angle < 150 && notIdle > 0){// up
            animator.Play("player_walk_up");
        }
        else if (angle > 31 && angle < 150 && notIdle < 1){// up idle
            animator.Play("player_idle_up");
        }
        else if (angle > 210.1 && angle < 330 && notIdle > 0){//down
            animator.Play("player_walk_down");
        }
        else if (angle > 210.1 && angle < 330 && notIdle < 1){//down idle
            animator.Play("player_idle_down");
        }
        else if (angle > 150.1 && angle < 210 && notIdle > 0){//left
            animator.Play("player_walk_left");
        }
        else if (angle > 150.1 && angle < 210 && notIdle < 1){//left idle
            animator.Play("player_idle_left");
        }
        else if ((angle > 0 && angle <30) || (angle > 331 && angle < 360) && notIdle > 0){//right
            animator.Play("player_idle_right");
        }
        else if ((angle > 0 && angle <30) || (angle > 331 && angle < 360) && notIdle < 1){//right idle
            animator.Play("player_idle_right");
        }
        else
            animator.Play("player_idle_down");//failcase
    }
}