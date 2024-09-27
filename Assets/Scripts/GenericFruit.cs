using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFruit : MonoBehaviour
{
    public FruitPreset preset;
    

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
        this.FruitChild = Instantiate(newpreset.FruitModel, FruitChild.transform);
        this.FruitChild.AddComponent<Autorotate>();
    }

    // Update is called once per frame
    void Update()
    {
        this.FruitChild.transform.localScale = Vector3.one * this.preset.Size;

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