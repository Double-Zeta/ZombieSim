using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeState : State
{
    public GameObject target;
    public override State RunCurrentState()
    {
        DesiredPosition = -target.transform.position;
        return this;
    }

    
}
