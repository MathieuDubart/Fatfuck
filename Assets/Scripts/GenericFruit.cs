using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFruit : MonoBehaviour
{
    public FruitPreset preset;
    public Autorotate BodyAutorotate;

    public GameObject FruitChild;

    [SerializeField]
    public ScoreController score;
    // Start is called before the first frame update



    public void DestroyFruit ()
    {
    if( this.FruitChild != null ){
      if (this.FruitChild.transform.position.y < -5f) 
         {
         Destroy(this.gameObject);
         }
}
       
         
    }   
    
    public void Init(FruitPreset newpreset)
    {
        this.preset = newpreset;
        this.FruitChild = Instantiate(newpreset.FruitModel, BodyAutorotate.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        this.BodyAutorotate.gameObject.transform.localScale = Vector3.one * this.preset.Size;
        this.BodyAutorotate.speed = preset.rotateSelfSpeed;
        this.DestroyFruit();

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            score.IncrementBy(preset.fruitValue);
        }
    }
}