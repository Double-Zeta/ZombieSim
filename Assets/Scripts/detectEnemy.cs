using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectEnemy : MonoBehaviour
{
    [SerializeField]
    WanderState wanderState;

    private void OnTriggerEnter(Collider other)
    {
        wanderState.canSeeEnemy = true;
    }
}
