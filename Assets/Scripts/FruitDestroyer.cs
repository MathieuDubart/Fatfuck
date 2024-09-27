using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDestroyer : MonoBehaviour
{

    
    void DestroyFruit (){
         if (transform.position.y < -5f) {
         Destroy(gameObject);
     }
    }

    // Update is called once per frame
    void Update()
    {
        DestroyFruit();
    }
}