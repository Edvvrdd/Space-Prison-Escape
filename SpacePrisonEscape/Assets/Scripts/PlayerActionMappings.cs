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
                },
                {
                    ""name"": ""Climb"",
                    ""type"": ""PassThrough"",
                    ""id"": ""acecff1d-e6de-49cb-85ee-7c3862b49f24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""e78e50cb-ddd4-4288-bbe5-6563d2fb5681"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""61b095a1-ea1e-4aaf-9e67-b4bd4c6eca0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""9c8bd73f-f8ed-4944-8d00-9384b4c2788d"",
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""97015e80-f969-4ee2-be5e-76ed35dbcab7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d93d444c-c012-49d6-8e05-7f1fbaa9ac93"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2eba072f-cb5d-4874-9011-fccdfec765c9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""894ff969-9977-4bd2-a925-41b71ae7b334"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e3b90df-b2df-4bf1-bd2a-676780fee6ba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""456d7806-0b7e-41d6-9a40-38714b323855"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_LandMovement_Climb = m_LandMovement.FindAction("Climb", throwIfNotFound: true);
        m_LandMovement_Reset = m_LandMovement.FindAction("Reset", throwIfNotFound: true);
        m_LandMovement_Select = m_LandMovement.FindAction("Select", throwIfNotFound: true);
        m_LandMovement_QuitGame = m_LandMovement.FindAction("QuitGame", throwIfNotFound: true);
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
    private readonly InputAction m_LandMovement_Climb;
    private readonly InputAction m_LandMovement_Reset;
    private readonly InputAction m_LandMovement_Select;
    private readonly InputAction m_LandMovement_QuitGame;
    public struct LandMovementActions
    {
        private @PlayerActionMappings m_Wrapper;
        public LandMovementActions(@PlayerActionMappings wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_LandMovement_Move;
        public InputAction @Jump => m_Wrapper.m_LandMovement_Jump;
        public InputAction @Rotate => m_Wrapper.m_LandMovement_Rotate;
        public InputAction @Climb => m_Wrapper.m_LandMovement_Climb;
        public InputAction @Reset => m_Wrapper.m_LandMovement_Reset;
        public InputAction @Select => m_Wrapper.m_LandMovement_Select;
        public InputAction @QuitGame => m_Wrapper.m_LandMovement_QuitGame;
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
                @Climb.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
                @Climb.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
                @Climb.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
                @Reset.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnReset;
                @Select.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnSelect;
                @QuitGame.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnQuitGame;
                @QuitGame.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnQuitGame;
                @QuitGame.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnQuitGame;
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
                @Climb.started += instance.OnClimb;
                @Climb.performed += instance.OnClimb;
                @Climb.canceled += instance.OnClimb;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @QuitGame.started += instance.OnQuitGame;
                @QuitGame.performed += instance.OnQuitGame;
                @QuitGame.canceled += instance.OnQuitGame;
            }
        }
    }
    public LandMovementActions @LandMovement => new LandMovementActions(this);
    public interface ILandMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
    }
}
