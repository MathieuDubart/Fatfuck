using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFruit : MonoBehaviour
{
    public FruitPreset preset;
    public GameObject FruitChild;

    public void DestroyFruit ()
    {
        if( this.FruitChild != null ){
            Destroy(this.gameObject);
        }
    }   
    
    public void Init(FruitPreset newpreset)
    {
        this.preset = newpreset;
        this.FruitChild = Instantiate(newpreset.FruitModel, FruitChild.transform);
        this.FruitChild.AddComponent<Autorotate>();
        this.FruitChild.AddComponent<FruitCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        this.FruitChild.transform.localScale = Vector3.one * this.preset.Size;
        if (this.FruitChild.transform.position.y < -5f)
        {
            Destroy(this.gameObject);
        }
    }
}