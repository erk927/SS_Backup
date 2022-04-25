using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRangedTracking : MonoBehaviour
{
    //Data Fields
    public float lerpSpeed = 0.3f;
    public float speed = 1f;//Enemy speed, shoud be able to modify it with a difficulty setting
    GameObject player;

    [SerializeField]private float attackRange = 1f;
    private float distanceToPlayer;
    private Animator animator;
    private float angle;
    
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float bulletSpeed;
    public float fireDelay = 1f;
    private Transform barrel;
    bool canFire = true;

    private EnemyRangedRotation direction;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");//FInd the player object
        animator = gameObject.GetComponent<Animator>();
        // barrel = GameObject.FindWithTag("rangedBarrel").GetComponent<Transform>();
        direction = gameObject.GetComponentInChildren<EnemyRangedRotation>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        //Trying something simple
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        angle = AngleBetweenPoints(transform.position, player.transform.position);//Angle b/t player and enemy
        changeDirection();
    }

    //Changes character animation depending on where the mouse cursor is
    public void changeDirection(){
        distanceToPlayer = Vector2.Distance(player.transform.position, transform.position);

        if (distanceToPlayer < attackRange && canFire){
            canFire = false;
            StartCoroutine(attack());
        }
        else if (angle > 31 && angle < 150){// up
            animator.Play("range_enemy_back_walk");
        }
        else if (angle > 210.1 && angle < 330){//down
            animator.Play("range_enemy_walk");
        }
        else if (angle > 150.1 && angle < 210){//left
            animator.Play("range_enemy_left_walk");
        }
        else if ((angle > 0 && angle <30) || (angle > 331 && angle < 360)){//right
            animator.Play("range_enemy_right_walk");
        }
        else
            animator.Play("range_enemy_walk");//failcase
    }

    //Causes enemy to stand still and fire at set interval
    IEnumerator attack(){
        float orignalSpeed = speed;
        speed = 0;
        StartCoroutine(direction.attack(pfBullet, bulletSpeed));
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
        speed = orignalSpeed;
        yield return null;
    }

    public float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg + 180;
     }
}
