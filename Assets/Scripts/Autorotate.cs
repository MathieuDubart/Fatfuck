using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Autorotate : MonoBehaviour
{

    public float speed = 0.01f;

   
    // Update is called once per frame
    void Update()
    {
        float dt= Time.deltaTime;
        float angle = dt * speed;

        angle *= GameController.Instance().simulationSpeed;
        this.gameObject.transform.Rotate(Vector3.up,angle, Space.Self);

    }
}


