using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        var parent = this.transform.parent.gameObject.GetComponent<GenericFruit>();
        
        if (collisionInfo.collider.tag == "Player")
        {
            ScoreController.Instance().IncrementScoreBy(parent.preset.fruitValue);
            ScoreController.Instance().IncrementComboWith(parent.preset.fruitMultiplier);
            Debug.Log(ScoreController.Instance().score);
            Debug.Log(ScoreController.Instance().combo);
            parent.DestroyFruit();

        }
    }
}
