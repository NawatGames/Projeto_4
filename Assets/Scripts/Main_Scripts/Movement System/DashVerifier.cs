// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;

// public class DashVerifier : MonoBehaviour
// {
//     [SerializeField] private DashingController dashingController;
//     [SerializeField] private DashingFinisherController dashingFinisherController;
//     [SerializeField] private GroundHandler groundHandler;
//     private bool isDashing;
//     private int dashCount;


//     private void OnEnable()
//     {
//         dashingController.DashStartEvent.AddListener(OnDashingStart);
//         dashingFinisherController.DashFinishedEvent.AddListener((OnDashingFinished));
//         groundHandler.touchGroundEvent.AddListener(OnTouchGround);
//     }

//     private void OnTouchGround(bool arg0)
//     {
//         dashCount = 0;
        
//     }


//     private void OnDashingFinished()
//     {
//         isDashing = false;

//     }

//     private void OnDisable()
//     {
//         dashingController.DashStartEvent.RemoveListener(OnDashingStart);
//         dashingFinisherController.DashFinishedEvent.RemoveListener((OnDashingFinished));
//         groundHandler.touchGroundEvent.RemoveListener(OnTouchGround);

//     }

//     private void OnDashingStart()
//     {
        
//         isDashing = true;
//         if (!groundHandler.IsGrounded)
//         {
//             dashCount += 1;
//         }
//     }

//     public bool Verify()
//     {
        
//         return !isDashing  && dashCount < 1;
//     }
// }
