using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : BaseController<InputController>
{


    public delegate void InputEvent();
    public event InputEvent OnTogglePause;
    public PlayerMovements pm;

    private float horizontalAxis = 0f;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if(this.OnTogglePause != null)
                this.OnTogglePause();
                //GameController.Instance().TogglePause();

        horizontalAxis = Input.GetAxis("Horizontal");
    }

    public void FixedUpdate()
    {
        pm.MovePlayerWith(horizontalAxis);
    }
}