using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFruit : MonoBehaviour
{
    public FruitPreset preset;
    
    public Autorotate BodyAutorotate;
    // Start is called before the first frame update
    public void Init(FruitPreset newpreset)
    {
        this.preset = newpreset;
        GameObject.Instantiate(newpreset.FruitModel, BodyAutorotate.transform);
    }

    // Update is called once per frame
    void Update()
    {
        this.BodyAutorotate.gameObject.transform.localScale = Vector3.one * this.preset.Size;
        this.BodyAutorotate.speed = preset.rotateSelfSpeed;
        

    }
}