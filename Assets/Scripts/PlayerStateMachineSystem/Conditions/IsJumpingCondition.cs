// using System;
// using EventSystem.SimpleEvents;
// using Movement_System;
// using UnityEngine;

// namespace PlayerStateMachineSystem.Conditions
// {
//     public class IsJumpingCondition : Condition
//     {
//         [SerializeField] private CharacterMovementHandler characterMovementHandler;
//         [SerializeField] private CheckCharacterFall checkCharacterFall;
        
//         [SerializeField] private bool isJumping;
        
//         private void Awake()
//         {
//             characterMovementHandler.characterJumpedEvent.AddListener(OnJumpStarting);
//             checkCharacterFall.fallingEvent.AddListener(OnFalling);
//         }

//         private void OnFalling(bool arg0)
//         {
//             if (arg0)
//             {
//                 isJumping = false;
//             }
//         }

//         private void OnDestroy()
//         {
//             characterMovementHandler.characterJumpedEvent.RemoveListener(OnJumpStarting);
//         }

        
//         private void OnJumpStarting()
//         {
//             isJumping = true;
//         }
        
//         public override bool Validate()
//         {
//             return isJumping;
//         }
//     }
// }