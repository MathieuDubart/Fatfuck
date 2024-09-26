using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public FruitPreset preset;
    public Autorotate BodyAutorotate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.BodyAutorotate.gameObject.transform.localScale = Vector3.one * this.preset.Size;
        this.BodyAutorotate.speed = preset.rotateSelfSpeed;

    }
}