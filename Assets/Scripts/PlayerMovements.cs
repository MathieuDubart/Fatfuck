using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float sidewayForce = 5f;

    private float horizontalAxis = 0f;

    private void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.transform.position += new Vector3(horizontalAxis * sidewayForce * Time.deltaTime, 0, 0);
    }
}
