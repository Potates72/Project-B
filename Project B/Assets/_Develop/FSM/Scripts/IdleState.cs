using UnityEditor;
using UnityEngine;

namespace Assets._Develop.Scripts
{
    [CreateAssetMenu(fileName ="IdleState", menuName ="Finite State Machine/States/Idle", order =0)]
    public class IdleState : State
    {
        public override bool EnterState()
        { 
            base.EnterState();

            Debug.Log("Entering IDLE state");

            return true;
        }

        public override void UpdateState()
        {
            Debug.Log("Updating IDLE state");
        }

        public override bool ExitState()
        {
            base.ExitState();

            Debug.Log("Exiting IDLE state");

            return true;
        }
    }
}