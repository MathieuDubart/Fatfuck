using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float sidewayForce = 5f;

    Camera cam;
    Vector3 pointLeft;
    Vector3 pointRight;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        

        // Retrieving left & right points to keep player in camera fov.
        pointLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, 10));
        pointRight = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, 10));
    }

    public void MovePlayerWith(float horizontalAxis)
    {
        if ((this.gameObject.transform.position.x > pointLeft.x && horizontalAxis <= 0) || (this.gameObject.transform.position.x < pointRight.x && horizontalAxis >= 0))
        {
            this.gameObject.transform.position += new Vector3(horizontalAxis * sidewayForce * Time.deltaTime, 0, 0);
        }
    }

    /* Uncomment to display debug infos about cam borders.
     * private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("World left position: " + pointLeft.ToString("F3"));
        GUILayout.Label("World right position: " + pointRight.ToString("F3"));
        GUILayout.EndArea();
    }
    */
}
