using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : State
{
    public ChaseState chaseState;
    public bool canSeeEnemy;
    public override State RunCurrentState()
    {
        if (canSeeEnemy)
        {
            return chaseState;
        }
        else
        {
            {
                return this;
            }
        }
    }

   
}
