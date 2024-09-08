// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MovementVerifier : MonoBehaviour
// {
//     [SerializeField] private GroundHandler groundHandler;

//     [SerializeField] private bool isGrounded;


//     private void OnEnable()
//     {
//         groundHandler.touchGroundEvent.AddListener(OnTouchGround);
//     }


//     private void OnDisable()
//     {
//         groundHandler.touchGroundEvent.RemoveListener(OnTouchGround);
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
//     public bool CanJump()
//     {
//         return isGrounded;
//     }

//     private void OnTouchGround(bool isGrounded)
//     {
//         this.isGrounded = isGrounded;
//     }
// }
