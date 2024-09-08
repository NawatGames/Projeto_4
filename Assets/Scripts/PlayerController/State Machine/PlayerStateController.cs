using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateController : MonoBehaviour
{
    public PlayerBaseState superState;
    public PlayerBaseState subState;
    public GroundHandler groundHandler;
    public Vector2 movementInput;
    public bool isDashing;
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        superState = gameObject.GetComponentInChildren<PlayerGroundState>();
        subState = gameObject.GetComponentInChildren<PlayerIdleState>();
        superState.Enter();
        subState.Enter();

    }

    // Update is called once per frame
    void Update()
    {
        superState.Do();
        isGrounded = groundHandler.isGrounded;
    }

    void FixedUpdate()
    {
        superState.FixedDo();
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movementInput.x = context.ReadValue<float>();

        }
        if (context.canceled)
        {
            movementInput.x = context.ReadValue<float>();
        }
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Debug.Log("Jumping...");
            movementInput.y = context.ReadValue<float>();
        }
        if (context.canceled)
        {
            movementInput.y = context.ReadValue<float>();
        }
    }
    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Debug.Log("Jumping...");
            isDashing = context.ReadValueAsButton();
        }
        if (context.canceled)
        {
            isDashing = context.ReadValueAsButton();
        }
    }
}
