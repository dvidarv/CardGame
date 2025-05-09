//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/InputSystem/InputActions.inputactions
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

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""MouseActions"",
            ""id"": ""b65c8288-0eeb-4ec3-8c92-825fbc747574"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""4a4d2b44-9f98-4d42-822c-5a05d379d23e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""de24ca85-6d9d-4eda-ba60-2566edd603fb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""6ae6f214-435c-4fa1-8fef-43786f14ae47"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""bb378dc6-fe11-47a2-a37a-ad659bb52ed8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""64121776-816e-4c3b-b414-60d92792c7f6"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94de9ce8-1656-402e-954d-ba73a7099374"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""951da1ee-cd73-4b4c-b228-61a53e4ebe55"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4de4139-ec1b-4678-bff8-11f3d9422dca"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseActions
        m_MouseActions = asset.FindActionMap("MouseActions", throwIfNotFound: true);
        m_MouseActions_Point = m_MouseActions.FindAction("Point", throwIfNotFound: true);
        m_MouseActions_LeftClick = m_MouseActions.FindAction("LeftClick", throwIfNotFound: true);
        m_MouseActions_RightClick = m_MouseActions.FindAction("RightClick", throwIfNotFound: true);
        m_MouseActions_Scroll = m_MouseActions.FindAction("Scroll", throwIfNotFound: true);
    }

    ~@InputActions()
    {
        UnityEngine.Debug.Assert(!m_MouseActions.enabled, "This will cause a leak and performance issues, InputActions.MouseActions.Disable() has not been called.");
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

    // MouseActions
    private readonly InputActionMap m_MouseActions;
    private List<IMouseActionsActions> m_MouseActionsActionsCallbackInterfaces = new List<IMouseActionsActions>();
    private readonly InputAction m_MouseActions_Point;
    private readonly InputAction m_MouseActions_LeftClick;
    private readonly InputAction m_MouseActions_RightClick;
    private readonly InputAction m_MouseActions_Scroll;
    public struct MouseActionsActions
    {
        private @InputActions m_Wrapper;
        public MouseActionsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_MouseActions_Point;
        public InputAction @LeftClick => m_Wrapper.m_MouseActions_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_MouseActions_RightClick;
        public InputAction @Scroll => m_Wrapper.m_MouseActions_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_MouseActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionsActions set) { return set.Get(); }
        public void AddCallbacks(IMouseActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseActionsActionsCallbackInterfaces.Add(instance);
            @Point.started += instance.OnPoint;
            @Point.performed += instance.OnPoint;
            @Point.canceled += instance.OnPoint;
            @LeftClick.started += instance.OnLeftClick;
            @LeftClick.performed += instance.OnLeftClick;
            @LeftClick.canceled += instance.OnLeftClick;
            @RightClick.started += instance.OnRightClick;
            @RightClick.performed += instance.OnRightClick;
            @RightClick.canceled += instance.OnRightClick;
            @Scroll.started += instance.OnScroll;
            @Scroll.performed += instance.OnScroll;
            @Scroll.canceled += instance.OnScroll;
        }

        private void UnregisterCallbacks(IMouseActionsActions instance)
        {
            @Point.started -= instance.OnPoint;
            @Point.performed -= instance.OnPoint;
            @Point.canceled -= instance.OnPoint;
            @LeftClick.started -= instance.OnLeftClick;
            @LeftClick.performed -= instance.OnLeftClick;
            @LeftClick.canceled -= instance.OnLeftClick;
            @RightClick.started -= instance.OnRightClick;
            @RightClick.performed -= instance.OnRightClick;
            @RightClick.canceled -= instance.OnRightClick;
            @Scroll.started -= instance.OnScroll;
            @Scroll.performed -= instance.OnScroll;
            @Scroll.canceled -= instance.OnScroll;
        }

        public void RemoveCallbacks(IMouseActionsActions instance)
        {
            if (m_Wrapper.m_MouseActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseActionsActions @MouseActions => new MouseActionsActions(this);
    public interface IMouseActionsActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}
