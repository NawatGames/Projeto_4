using System;
using System.Collections;
using System.Collections.Generic;
using Movement_System;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private CharacterMovementHandler characterMovementHandler;
    [SerializeField] private MovementVerifier movementVerifier;

    [SerializeField] float jumpSpeed = 1f;
    [SerializeField] Vector2 inputDirection = Vector2.zero;
    [SerializeField] float walkSpeed = 1f;


    [SerializeField] private Vector2Event movementDirectionEvent; 
    [SerializeField] private BoolEvent jumpChangedEvent; 
    
    private void OnEnable()
    {
        movementDirectionEvent.SubscribeUnityEvent(OnInputDirectionChanged);
        jumpChangedEvent.SubscribeUnityEvent(OnJumpChanged);
    }

    private void OnJumpChanged(bool arg0)
    {
        if (arg0)
        {
            OnJumpRequest();
        }
    }


    private void OnDisable()
    {
        movementDirectionEvent.UnsubscribeUnityEvent(OnInputDirectionChanged);
        jumpChangedEvent.UnsubscribeUnityEvent(OnJumpChanged);

    }

    [ContextMenu("Jump Request")]
    public void OnJumpRequest()
    {
        if(movementVerifier.CanJump())
        {
            characterMovementHandler.Jump(Vector2.up * jumpSpeed);
        }
        
    }

    void Update()
    {
        characterMovementHandler.Move(inputDirection, walkSpeed);
    }

    private void OnInputDirectionChanged(Vector2 inputDirection)
    {
        inputDirection.y = 0;
        this.inputDirection = inputDirection;
    }

}
