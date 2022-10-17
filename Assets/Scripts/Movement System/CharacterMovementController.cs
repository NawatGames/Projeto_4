using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private CharacterMovementHandler characterMovementHandler;
    [SerializeField] private MovementVerifier movementVerifier;

    [SerializeField] float jumpSpeed = 1f;
    [SerializeField] Vector2 inputDirection = Vector2.zero;
    [SerializeField] float walkSpeed = 1f;
    private void OnEnable()
    {
        
    }


    private void OnDisable()
    {

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
        this.inputDirection = inputDirection;
    }

}
