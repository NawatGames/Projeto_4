using System;
using UnityEngine;

namespace PlayerStateMachineSystem
{
    [Serializable]
    public struct StateTransition
    {
        public Condition condition;
        [Tooltip("Null to not change state")]
        public PlayerState successCase;
        [Tooltip("Null to not change state")]
        public PlayerState failCase;
    }
}