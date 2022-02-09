// GENERATED AUTOMATICALLY FROM 'Assets/Core/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""KeyCommands"",
            ""id"": ""18d7972c-7055-42de-bfc4-1508a1242388"",
            ""actions"": [
                {
                    ""name"": ""Button1"",
                    ""type"": ""Button"",
                    ""id"": ""265243fc-bdf2-4a3c-a7b7-6734b9015e18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button2"",
                    ""type"": ""Button"",
                    ""id"": ""3531c99c-d1e7-4acd-9997-f0bc395c63ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button3"",
                    ""type"": ""Button"",
                    ""id"": ""25382fc2-d1fc-4b5d-959c-e931029119cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button4"",
                    ""type"": ""Button"",
                    ""id"": ""468d2667-4a95-49cc-9f7a-fa298e12e1d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button5"",
                    ""type"": ""Button"",
                    ""id"": ""779596cb-58e7-4658-8911-46d2decbd7c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""964706f5-4550-47df-b353-c561094fcc8a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77e036b9-8a63-4b5c-9c4d-db73ce85bdc0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b4e0ea6-2271-4f27-a34d-b3d72b5bb4f3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e330e5d-f7cd-448d-a68a-0f9e305a68d4"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aec752b1-27f9-4ac5-898b-7cec5a536bf2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerAction"",
            ""id"": ""8a5d1784-c807-4bb9-8c54-da7e3ff85519"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3165e92-4cef-496a-84db-4617c49e7df8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1a5685bb-ba48-4e53-9da0-718668a53bc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f11a7d28-8b51-495e-a5f9-3c1e15ce80e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""31daaac8-dbad-41a8-9170-3f0322608453"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4c8216ed-a50b-44e8-a612-8f19930f3cc4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8bb903f9-6a79-45c7-be96-5d340f8accde"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""021eabfc-67e0-44d0-b81f-2f82ab9a98d5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""67d6d4d7-3279-42b1-abe9-a29b58bc211a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""812f9618-ea7c-486c-8f83-5b6524670757"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cd70eed-1162-46fb-b0f6-8fe362aca4f3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyCommands
        m_KeyCommands = asset.FindActionMap("KeyCommands", throwIfNotFound: true);
        m_KeyCommands_Button1 = m_KeyCommands.FindAction("Button1", throwIfNotFound: true);
        m_KeyCommands_Button2 = m_KeyCommands.FindAction("Button2", throwIfNotFound: true);
        m_KeyCommands_Button3 = m_KeyCommands.FindAction("Button3", throwIfNotFound: true);
        m_KeyCommands_Button4 = m_KeyCommands.FindAction("Button4", throwIfNotFound: true);
        m_KeyCommands_Button5 = m_KeyCommands.FindAction("Button5", throwIfNotFound: true);
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_Move = m_PlayerAction.FindAction("Move", throwIfNotFound: true);
        m_PlayerAction_Jump = m_PlayerAction.FindAction("Jump", throwIfNotFound: true);
        m_PlayerAction_Sprint = m_PlayerAction.FindAction("Sprint", throwIfNotFound: true);
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

    // KeyCommands
    private readonly InputActionMap m_KeyCommands;
    private IKeyCommandsActions m_KeyCommandsActionsCallbackInterface;
    private readonly InputAction m_KeyCommands_Button1;
    private readonly InputAction m_KeyCommands_Button2;
    private readonly InputAction m_KeyCommands_Button3;
    private readonly InputAction m_KeyCommands_Button4;
    private readonly InputAction m_KeyCommands_Button5;
    public struct KeyCommandsActions
    {
        private @PlayerInputActions m_Wrapper;
        public KeyCommandsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Button1 => m_Wrapper.m_KeyCommands_Button1;
        public InputAction @Button2 => m_Wrapper.m_KeyCommands_Button2;
        public InputAction @Button3 => m_Wrapper.m_KeyCommands_Button3;
        public InputAction @Button4 => m_Wrapper.m_KeyCommands_Button4;
        public InputAction @Button5 => m_Wrapper.m_KeyCommands_Button5;
        public InputActionMap Get() { return m_Wrapper.m_KeyCommands; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyCommandsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyCommandsActions instance)
        {
            if (m_Wrapper.m_KeyCommandsActionsCallbackInterface != null)
            {
                @Button1.started -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton1;
                @Button1.performed -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton1;
                @Button1.canceled -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton1;
                @Button2.started -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton2;
                @Button2.performed -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton2;
                @Button2.canceled -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton2;
                @Button3.started -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton3;
                @Button3.performed -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton3;
                @Button3.canceled -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton3;
                @Button4.started -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton4;
                @Button4.performed -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton4;
                @Button4.canceled -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton4;
                @Button5.started -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton5;
                @Button5.performed -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton5;
                @Button5.canceled -= m_Wrapper.m_KeyCommandsActionsCallbackInterface.OnButton5;
            }
            m_Wrapper.m_KeyCommandsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Button1.started += instance.OnButton1;
                @Button1.performed += instance.OnButton1;
                @Button1.canceled += instance.OnButton1;
                @Button2.started += instance.OnButton2;
                @Button2.performed += instance.OnButton2;
                @Button2.canceled += instance.OnButton2;
                @Button3.started += instance.OnButton3;
                @Button3.performed += instance.OnButton3;
                @Button3.canceled += instance.OnButton3;
                @Button4.started += instance.OnButton4;
                @Button4.performed += instance.OnButton4;
                @Button4.canceled += instance.OnButton4;
                @Button5.started += instance.OnButton5;
                @Button5.performed += instance.OnButton5;
                @Button5.canceled += instance.OnButton5;
            }
        }
    }
    public KeyCommandsActions @KeyCommands => new KeyCommandsActions(this);

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_Move;
    private readonly InputAction m_PlayerAction_Jump;
    private readonly InputAction m_PlayerAction_Sprint;
    public struct PlayerActionActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActionActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerAction_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerAction_Jump;
        public InputAction @Sprint => m_Wrapper.m_PlayerAction_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);
    public interface IKeyCommandsActions
    {
        void OnButton1(InputAction.CallbackContext context);
        void OnButton2(InputAction.CallbackContext context);
        void OnButton3(InputAction.CallbackContext context);
        void OnButton4(InputAction.CallbackContext context);
        void OnButton5(InputAction.CallbackContext context);
    }
    public interface IPlayerActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
