using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : BaseController<GameController>
{

    public delegate void SpeedEvent(float newSpeed);
    public SpeedEvent OnSpeedChanged;


    private float _speed = 1;

    public float simulationSpeed { get
        {
            return _speed;
        }
        set {
            _speed = value;
            if(this.OnSpeedChanged != null)
                this.OnSpeedChanged(value);
        } }
    public float? previousSpeed = null;

    


    public void Start()
    {
       
    }

    public void TogglePause()
    {
        if (this.simulationSpeed == 0)
        {
            if (this.previousSpeed.HasValue)
                this.simulationSpeed = this.previousSpeed.Value;
            else
                this.simulationSpeed = 1;
        }

        else
        {
            this.previousSpeed = this.simulationSpeed;
            this.simulationSpeed = 0;

        }
    }


}