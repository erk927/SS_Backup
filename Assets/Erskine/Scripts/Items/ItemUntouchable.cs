using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUntouchable : MonoBehaviour
{
     private PlayerDamage pd;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        pd = player.GetComponent<PlayerDamage>();
        if(pd == null)
        {
             Debug.Log("pd is null");
        }
    }

   private void OnCollisionEnter2D(Collision2D other){
        Physics2D.IgnoreLayerCollision(14, 13);//enemies
        Physics2D.IgnoreLayerCollision(14, 10);//bullets

        Debug.Log("Trying to activate star");
        pd.activateStar();

        Destroy(gameObject);
   }
}
