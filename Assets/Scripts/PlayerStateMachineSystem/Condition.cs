using UnityEngine;

namespace PlayerStateMachineSystem
{
    public abstract class Condition : MonoBehaviour
    {
        public abstract bool Validate();
    }
}