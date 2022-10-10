using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public AttackState attackState;
    public bool isInAttackRange;
    public GameObject target;
    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            return attackState;
        }
        else
        {
            DesiredPosition = -target.transform.position;
            return this;
        }
    }

}
