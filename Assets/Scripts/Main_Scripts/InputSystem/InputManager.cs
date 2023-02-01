using Core;
using EventSystem.SimpleEvents;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputSystem {
    public class InputManager : Singleton<InputManager>, InputMap.IMovementActions, InputMap.IElementSelectionActions, InputMap.IDrawingMouseActions {

        private InputMap inputMap;
        
        public Vector2Event walkDirectionChangedEvent;
        public BoolEvent  jumpChangedEvent;
        public IntegerEvent elementSelectedEvent;
        public Vector2TupleEvent mouseInitialAndEndPointEvent;

        private Vector2 _mouseInitialPoint;


        private void Awake() {
            instance = this;
            inputMap = new InputMap();
            inputMap.Movement.SetCallbacks(this);
            inputMap.ElementSelection.SetCallbacks(this);
            inputMap.DrawingMouse.SetCallbacks(this);
            inputMap.Enable();

        }

        private void OnDestroy() {
            inputMap.Dispose();
        }

        private void OnDisable() {
            inputMap.Disable();
        }
        
        

        public void OnWalk(InputAction.CallbackContext context) {
            walkDirectionChangedEvent.InvokeEvent(context.ReadValue<Vector2>());
        }

        public void OnJump(InputAction.CallbackContext context) {
            jumpChangedEvent.InvokeEvent(context.ReadValueAsButton());
        }


        public void OnElement1(InputAction.CallbackContext context) {
            if(context.performed)
                elementSelectedEvent.InvokeEvent(1);
        }

        public void OnElement2(InputAction.CallbackContext context) {
            if(context.performed)
                elementSelectedEvent.InvokeEvent(2);
        }

        public void OnElement3(InputAction.CallbackContext context) {
            if(context.performed)
                elementSelectedEvent.InvokeEvent(3);
        }

        public void OnElement4(InputAction.CallbackContext context) {
            if(context.performed)
                elementSelectedEvent.InvokeEvent(4);
        }


        public void OnLeftClick(InputAction.CallbackContext context) {
            Vector2 endPoint;
            
            if(context.performed) {
                _mouseInitialPoint = GetMouseWorldPosition();
            }
            if(context.canceled) {
                endPoint = GetMouseWorldPosition();
                mouseInitialAndEndPointEvent.InvokeEvent((_mouseInitialPoint, endPoint));
            }
        }

        private static Vector2 GetMouseWorldPosition() {
            var mousePoint = Mouse.current.position.ReadValue();
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePoint);
            return mouseWorldPosition;
        }
    }
}