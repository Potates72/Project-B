using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private State startingState;

    private State currentState = null;

    private void Start()
    {
        EnterState(startingState);
    }

    private void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState();
        }
    }

    private void EnterState(State state)
    {
        if (state == null) return;

        currentState = state;
        currentState.EnterState();
    }
}
