using System;
using UnityEngine;

namespace PlayerStateMachineSystem
{
    public class PlayerStateMachine : MonoBehaviour
    {
        private PlayerState defaultPlayerState;
        private PlayerState currentPlayerState;
        private PlayerState lastFramePlayerState;
        private PlayerStateMachineEventHandler playerStateMachineEventHandler;
        private void LateUpdate()
        {
            lastFramePlayerState = currentPlayerState;
        }

        private void Update()
        {
            currentPlayerState.Execute(this);
        }

        public void SetState(PlayerState playerState)
        {
            playerState ??= defaultPlayerState;
            var previewsState = currentPlayerState;
            currentPlayerState = playerState;
            playerStateMachineEventHandler.InvokeEvents(currentPlayerState,previewsState);
        }
    }
}