using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateManager : MonoBehaviour
{
    public NavMeshAgent ZombieAgent;
    public State currentState;
    public GameObject detectionRadius;
    void Update()
    {
        RunStateMachine();
        ZombieAgent.SetDestination(currentState.DesiredPosition);
        
    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(State nextState)
    {
        currentState = nextState;
    }
}
