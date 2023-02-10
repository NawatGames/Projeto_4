using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PlayerStateMachineSystem
{
    public class PlayerState : MonoBehaviour
    {
        public string stateName;
        public List<StateAction> actions;
        public List<StateTransition> transitions;

        public UnityEvent EnterStateEvent;

        public void Execute(PlayerStateMachine playerStateMachine)
        {
            foreach (var action in actions)
            {
                action.Execute();
            }
            foreach (var transition in transitions)
            {
                var result = transition.condition.Validate();
                var nextState = result ? transition.successCase : transition.failCase;

                if (nextState != null)
                {
                    playerStateMachine.SetState(nextState);
                }
            }
        }
    }
}