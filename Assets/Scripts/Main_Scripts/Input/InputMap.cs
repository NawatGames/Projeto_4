//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scripts/Main_Scripts/Input/InputMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d1ade017-bc03-4d26-8f98-b37a7f10cdf8"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""71d03d08-bcbb-4c55-ab07-c57a765970ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6074fdfd-8173-4704-a37c-0faacf06710e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""029bee86-e58c-4bb5-958e-e2a93ff9a9d6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""406b1088-b842-4827-8a9b-331be88c88cb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f424c41f-ecef-4169-88b0-fac4c1a8c761"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""43ae2939-d499-4a2a-9a3d-1587ed2c9c2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0630c43-9fac-4ff6-8e31-bb15780f0da8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""473325fe-7ea1-4336-9058-bfea14347d1e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ElementSelection"",
            ""id"": ""b0b708ab-89e3-4845-a705-e260644cd2d3"",
            ""actions"": [
                {
                    ""name"": ""Element1"",
                    ""type"": ""Button"",
                    ""id"": ""a8354413-6a4d-42b4-8c6a-ba553a977b51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Element2"",
                    ""type"": ""Button"",
                    ""id"": ""91eb69fe-3fab-425a-8455-a61d1e34c204"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Element3"",
                    ""type"": ""Button"",
                    ""id"": ""b20ea6ed-6e36-493c-95af-7ad631757f3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Element4"",
                    ""type"": ""Button"",
                    ""id"": ""5cc439fd-dbd4-46d1-aee3-42ca01e1e2b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Element5"",
                    ""type"": ""Button"",
                    ""id"": ""10d2f788-5c89-4296-b43d-673834cfed31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f94fcae-f6c7-4ee0-9da5-1526b5635d98"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f95fbbd-48d7-4657-9a1e-afda1b9b98c0"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eab8607-c25d-4882-b114-8d88aec05caa"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06e837a1-f8f9-4b19-81b7-7988f89e231e"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b324eb50-9a12-45e7-89d1-18c0d727c874"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Element5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DrawingMouse"",
            ""id"": ""6a634da0-b848-449f-ba6b-38b6613bf1bf"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""2e9a4031-d332-428b-bed4-751922d669b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91475dd1-6aa0-4b9b-936b-6b5a77b846bc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Walk = m_Movement.FindAction("Walk", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
        // ElementSelection
        m_ElementSelection = asset.FindActionMap("ElementSelection", throwIfNotFound: true);
        m_ElementSelection_Element1 = m_ElementSelection.FindAction("Element1", throwIfNotFound: true);
        m_ElementSelection_Element2 = m_ElementSelection.FindAction("Element2", throwIfNotFound: true);
        m_ElementSelection_Element3 = m_ElementSelection.FindAction("Element3", throwIfNotFound: true);
        m_ElementSelection_Element4 = m_ElementSelection.FindAction("Element4", throwIfNotFound: true);
        m_ElementSelection_Element5 = m_ElementSelection.FindAction("Element5", throwIfNotFound: true);
        // DrawingMouse
        m_DrawingMouse = asset.FindActionMap("DrawingMouse", throwIfNotFound: true);
        m_DrawingMouse_LeftClick = m_DrawingMouse.FindAction("LeftClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Walk;
    private readonly InputAction m_Movement_Jump;
    public struct MovementActions
    {
        private @InputMap m_Wrapper;
        public MovementActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Movement_Walk;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // ElementSelection
    private readonly InputActionMap m_ElementSelection;
    private IElementSelectionActions m_ElementSelectionActionsCallbackInterface;
    private readonly InputAction m_ElementSelection_Element1;
    private readonly InputAction m_ElementSelection_Element2;
    private readonly InputAction m_ElementSelection_Element3;
    private readonly InputAction m_ElementSelection_Element4;
    private readonly InputAction m_ElementSelection_Element5;
    public struct ElementSelectionActions
    {
        private @InputMap m_Wrapper;
        public ElementSelectionActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Element1 => m_Wrapper.m_ElementSelection_Element1;
        public InputAction @Element2 => m_Wrapper.m_ElementSelection_Element2;
        public InputAction @Element3 => m_Wrapper.m_ElementSelection_Element3;
        public InputAction @Element4 => m_Wrapper.m_ElementSelection_Element4;
        public InputAction @Element5 => m_Wrapper.m_ElementSelection_Element5;
        public InputActionMap Get() { return m_Wrapper.m_ElementSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ElementSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IElementSelectionActions instance)
        {
            if (m_Wrapper.m_ElementSelectionActionsCallbackInterface != null)
            {
                @Element1.started -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement1;
                @Element1.performed -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement1;
                @Element1.canceled -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement1;
                @Element2.started -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement2;
                @Element2.performed -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement2;
                @Element2.canceled -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement2;
                @Element3.started -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement3;
                @Element3.performed -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement3;
                @Element3.canceled -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement3;
                @Element4.started -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement4;
                @Element4.performed -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement4;
                @Element4.canceled -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement4;
                @Element5.started -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement5;
                @Element5.performed -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement5;
                @Element5.canceled -= m_Wrapper.m_ElementSelectionActionsCallbackInterface.OnElement5;
            }
            m_Wrapper.m_ElementSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Element1.started += instance.OnElement1;
                @Element1.performed += instance.OnElement1;
                @Element1.canceled += instance.OnElement1;
                @Element2.started += instance.OnElement2;
                @Element2.performed += instance.OnElement2;
                @Element2.canceled += instance.OnElement2;
                @Element3.started += instance.OnElement3;
                @Element3.performed += instance.OnElement3;
                @Element3.canceled += instance.OnElement3;
                @Element4.started += instance.OnElement4;
                @Element4.performed += instance.OnElement4;
                @Element4.canceled += instance.OnElement4;
                @Element5.started += instance.OnElement5;
                @Element5.performed += instance.OnElement5;
                @Element5.canceled += instance.OnElement5;
            }
        }
    }
    public ElementSelectionActions @ElementSelection => new ElementSelectionActions(this);

    // DrawingMouse
    private readonly InputActionMap m_DrawingMouse;
    private IDrawingMouseActions m_DrawingMouseActionsCallbackInterface;
    private readonly InputAction m_DrawingMouse_LeftClick;
    public struct DrawingMouseActions
    {
        private @InputMap m_Wrapper;
        public DrawingMouseActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_DrawingMouse_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_DrawingMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrawingMouseActions set) { return set.Get(); }
        public void SetCallbacks(IDrawingMouseActions instance)
        {
            if (m_Wrapper.m_DrawingMouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_DrawingMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_DrawingMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_DrawingMouseActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_DrawingMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public DrawingMouseActions @DrawingMouse => new DrawingMouseActions(this);
    public interface IMovementActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IElementSelectionActions
    {
        void OnElement1(InputAction.CallbackContext context);
        void OnElement2(InputAction.CallbackContext context);
        void OnElement3(InputAction.CallbackContext context);
        void OnElement4(InputAction.CallbackContext context);
        void OnElement5(InputAction.CallbackContext context);
    }
    public interface IDrawingMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
