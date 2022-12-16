using System.Collections.Generic;
using UnityEngine;

namespace PlayerStateMachineSystem
{
    public class PlayerState : MonoBehaviour
    {
        public List<StateAction> actions;
        public List<StateTransition> transitions;
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