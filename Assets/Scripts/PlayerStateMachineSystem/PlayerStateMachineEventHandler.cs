using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace PlayerStateMachineSystem
{
    public class PlayerStateMachineEventHandler : MonoBehaviour
    {
        public UnityEvent<PlayerState> StateChanged;
        public void InvokeEvents([NotNull] PlayerState currentPlayerState, [NotNull] PlayerState previewsState)
        {
            if (currentPlayerState != previewsState)
            {
                StateChanged?.Invoke(currentPlayerState);
            }
        }
    }
}