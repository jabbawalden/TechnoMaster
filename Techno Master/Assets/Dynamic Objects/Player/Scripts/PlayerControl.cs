// GENERATED AUTOMATICALLY FROM 'Assets/Dynamic Objects/Player/Scripts/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""e50c46e0-68d6-4e4f-909e-8af1c2915a48"",
            ""actions"": [
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Button"",
                    ""id"": ""0378558a-9973-4983-989b-cde2c7c05e76"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YButton"",
                    ""type"": ""Button"",
                    ""id"": ""bbf6a8c2-249a-4561-9556-66796246c1b0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Button"",
                    ""id"": ""25a3b89a-f46e-42a4-b8ff-bdeeb389081d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f62bee1a-ea17-4c4b-a98a-fd1c270edad2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aedb1357-f6d9-4bc2-8bf8-8f2c41f21c4c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1be77c30-8bff-4097-b2b3-b65c124e8dda"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_LeftStick = m_PlayerInput.FindAction("LeftStick", throwIfNotFound: true);
        m_PlayerInput_YButton = m_PlayerInput.FindAction("YButton", throwIfNotFound: true);
        m_PlayerInput_RightStick = m_PlayerInput.FindAction("RightStick", throwIfNotFound: true);
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

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInput_LeftStick;
    private readonly InputAction m_PlayerInput_YButton;
    private readonly InputAction m_PlayerInput_RightStick;
    public struct PlayerInputActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerInputActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_PlayerInput_LeftStick;
        public InputAction @YButton => m_Wrapper.m_PlayerInput_YButton;
        public InputAction @RightStick => m_Wrapper.m_PlayerInput_RightStick;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLeftStick;
                @YButton.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnYButton;
                @YButton.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnYButton;
                @YButton.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnYButton;
                @RightStick.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnRightStick;
            }
            m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @YButton.started += instance.OnYButton;
                @YButton.performed += instance.OnYButton;
                @YButton.canceled += instance.OnYButton;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
            }
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    public interface IPlayerInputActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnYButton(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
    }
}
