// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;

// namespace Movement_System
// {
//     public class CheckCharacterFall : MonoBehaviour
//     {

//         [SerializeField] private Rigidbody2D rigidbody2D;
//         private Vector2 _lastFrameVelocity;
//         private Vector2 _currentFrameVelocity;
//         [SerializeField] private GroundHandler groundHandler;
//         [SerializeField] private bool isGrounded;
//         [SerializeField] private bool isFalling;
//         public UnityEvent<bool> fallingEvent;


//         private void Update()
//         {
//             _currentFrameVelocity = rigidbody2D.velocity;
//             if (_currentFrameVelocity.y < 0 && _lastFrameVelocity.y >= 0 && !isGrounded|| _currentFrameVelocity.y < 0 && !isGrounded && !isFalling)
//             {
//                 fallingEvent.Invoke(true);
//                 isFalling = true;
//             }

//             _lastFrameVelocity = _currentFrameVelocity;
//         }


//         private void OnEnable()
//         {
//             groundHandler.touchGroundEvent.AddListener(OnTouchGround);
//         }
        
//         private void OnDisable()
//         {
//             groundHandler.touchGroundEvent.RemoveListener(OnTouchGround);
//         }

//         private void OnTouchGround(bool arg0)
//         {
//             isGrounded = arg0;
//             if (isGrounded)
//             {
//                 isFalling = false;
//                 fallingEvent.Invoke(false);
//             }
//         }
//     }
// }