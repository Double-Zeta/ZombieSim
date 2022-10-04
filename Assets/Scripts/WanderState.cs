using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : State
{
    public ChaseState chaseState;
    public bool canSeeEnemy;
    public Vector3 MinRange;
    public Vector3 MaxRange; 
    
    public override State RunCurrentState()
    {
        if (canSeeEnemy)
        {
            return chaseState;
        }
        else
        {
            {
                MinRange = new Vector3(-10,0,-10);
                MaxRange = new Vector3(10, 0, 10);
                DesiredPosition = Random.Range(MinRange, MaxRange);
                return this;
            }
        }
    }
}
