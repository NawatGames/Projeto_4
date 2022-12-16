using System;
using UnityEngine;

namespace PlayerStateMachineSystem.Conditions
{
    public class IsGroundedCondition : Condition
    {
        public GroundHandler groundHandler;
        [SerializeField] private bool isGrounded;

        private void Awake()
        {
            groundHandler.touchGroundEvent.AddListener(OnTouchGround);
        }
        private void OnDestroy()
        {
            groundHandler.touchGroundEvent.RemoveListener(OnTouchGround);
        }

        private void OnTouchGround(bool arg0)
        {

            isGrounded = arg0;
        }

        public override bool Validate()
        {
            return isGrounded;
        }
    }
}