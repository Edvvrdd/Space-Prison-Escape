// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActionMappings.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionMappings : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionMappings()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionMappings"",
    ""maps"": [
        {
            ""name"": ""LandMovement"",
            ""id"": ""6292fba7-de5d-4748-a06f-9864221db732"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""92b782bf-2d4e-4b04-8bf4-b324ca401796"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e15e8dbc-1745-425e-ac85-01bfcf128c99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74c70a7f-87c4-41d0-bfb4-259e1342f639"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5963a68d-2d9f-4bb3-92f0-378a0aba33c8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f4b1f9b8-f1fe-4a3e-81c8-8a7aeef91ae0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""92f2bb4a-b8fa-4e47-90c8-5c2d4e620ca8"",
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
                    ""id"": ""9651dd7e-5c56-4135-8935-aa9eb94f565f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8c38f5a9-f9b2-48f8-9ecc-6a14295cf370"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e519f5a0-8b96-4259-b539-43e84c40ea1e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4577d5ba-f843-469d-b991-0bf1dd293b9b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LandMovement
        m_LandMovement = asset.FindActionMap("LandMovement", throwIfNotFound: true);
        m_LandMovement_Move = m_LandMovement.FindAction("Move", throwIfNotFound: true);
        m_LandMovement_Jump = m_LandMovement.FindAction("Jump", throwIfNotFound: true);
        m_LandMovement_Rotate = m_LandMovement.FindAction("Rotate", throwIfNotFound: true);
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

    // LandMovement
    private readonly InputActionMap m_LandMovement;
    private ILandMovementActions m_LandMovementActionsCallbackInterface;
    private readonly InputAction m_LandMovement_Move;
    private readonly InputAction m_LandMovement_Jump;
    private readonly InputAction m_LandMovement_Rotate;
    public struct LandMovementActions
    {
        private @PlayerActionMappings m_Wrapper;
        public LandMovementActions(@PlayerActionMappings wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_LandMovement_Move;
        public InputAction @Jump => m_Wrapper.m_LandMovement_Jump;
        public InputAction @Rotate => m_Wrapper.m_LandMovement_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_LandMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandMovementActions set) { return set.Get(); }
        public void SetCallbacks(ILandMovementActions instance)
        {
            if (m_Wrapper.m_LandMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Rotate.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_LandMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public LandMovementActions @LandMovement => new LandMovementActions(this);
    public interface ILandMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
