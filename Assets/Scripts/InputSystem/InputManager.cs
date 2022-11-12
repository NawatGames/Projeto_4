using System;
using Core;
using EventSystem;
using EventSystem.SimpleEvents;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace InputSystem
{
    public class InputManager : Singleton<InputManager>, InputMap.IMovementActions
    {

        private InputMap inputMap;
        
        public Vector2Event walkDirectionChangedEvent;
        public BoolEvent  jumpChangedEvent;

        private void Awake()
        {
            print("awake");
            instance = this;
            inputMap = new InputMap();
            inputMap.Movement.SetCallbacks(this);
            inputMap.Enable();

        }

        private void OnDestroy()
        {
            inputMap.Dispose();
        }

        private void OnDisable()
        {
            inputMap.Disable();
        }
        
        

        public void OnWalk(InputAction.CallbackContext context)
        {
            walkDirectionChangedEvent.InvokeEvent(context.ReadValue<Vector2>());
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            jumpChangedEvent.InvokeEvent(context.ReadValueAsButton());
        }
    }
}