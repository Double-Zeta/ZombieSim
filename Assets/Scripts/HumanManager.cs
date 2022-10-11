using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanManager : MonoBehaviour
{
    public NavMeshAgent HumanAgent;
    public State currentState;
    void Update()
    {
        RunStateMachine();
        HumanAgent.SetDestination(currentState.DesiredPosition);

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
