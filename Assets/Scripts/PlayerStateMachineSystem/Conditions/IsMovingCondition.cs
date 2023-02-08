using System;
using EventSystem.SimpleEvents;
using UnityEngine;

namespace PlayerStateMachineSystem.Conditions
{
    public class IsMovingCondition : Condition
    {
        [SerializeField] private Vector2Event movementDirectionEvent;
        [SerializeField] private bool isMoving;

        private void Awake()
        {
            movementDirectionEvent.SubscribeUnityEvent(OnMovementDirectionChanged);
        }

        private void OnMovementDirectionChanged(Vector2 arg0)
        {
            if (arg0.x != 0)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }
        }

        public override bool Validate()
        {
            return isMoving;
        }
    }
}