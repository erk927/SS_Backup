using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUntouchable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   private void OnCollisionEnter2D(Collision2D other) {
        Physics2D.IgnoreLayerCollision(14, 13);//enemies
        Physics2D.IgnoreLayerCollision(14, 10);//bullets

        

        Destroy(gameObject);
   }
}
