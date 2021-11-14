using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
public class Unit : MonoBehaviour
{
    private StateMachine stateMachine;

    private void Awake()
    {
        stateMachine = this.GetComponent<StateMachine>();
    }
    

}
