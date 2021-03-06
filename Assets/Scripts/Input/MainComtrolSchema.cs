// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/MainComtrolSchema.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Input
{
    public class @MainComtrolSchema : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MainComtrolSchema()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainComtrolSchema"",
    ""maps"": [
        {
            ""name"": ""Primary"",
            ""id"": ""531a8f58-b803-49a6-ad99-848d378a2f4b"",
            ""actions"": [
                {
                    ""name"": ""Move Left"",
                    ""type"": ""Button"",
                    ""id"": ""19d8cb04-5e96-4877-8319-675a740e63b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Right"",
                    ""type"": ""Button"",
                    ""id"": ""f05b9082-0bcd-4368-ac8b-f22e2a2adcf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Down"",
                    ""type"": ""Button"",
                    ""id"": ""78ed6f92-32af-46ce-b582-9218d64cbe5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Up"",
                    ""type"": ""Button"",
                    ""id"": ""ec82f88c-db37-449f-868a-6cf5e64db74b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ultimate"",
                    ""type"": ""Button"",
                    ""id"": ""17c24f7d-48d7-4e36-8899-8b554fe0d26f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Diagonal movement"",
                    ""type"": ""Value"",
                    ""id"": ""95f76de4-9da5-486b-b717-92ef06fabe3f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70117880-8fa8-48c1-9e8d-c1a8c221b1fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5b97463-c15a-45fd-ba1e-9b1a8e5c373f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80309e4c-c39b-48bd-a516-bc9ad940bb05"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1ad48ac-8abf-40cb-a219-1f86a0dcb826"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e300402-cdc5-40de-96e3-d9d58a04ae2e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6a165ef-4360-4961-a12b-023a17625d31"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbd3090-ccd5-449b-aad0-db0b40275e18"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f16afa6c-a738-42de-abac-40a898c5a9a1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85b9dc53-be33-4577-9974-411e042425e9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""541acf9c-a98d-4bee-9681-38fdc20740e1"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b8fa87c-215d-4bbf-ade2-aca3e933c3f2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15a714d1-d4bf-4d21-9fed-61a11d3fc042"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ead35f8e-d063-4d7f-b26e-7ab8f0339bd0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ultimate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c36d43cd-5dba-4d87-bf85-bcde098cc27c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea998ec0-c1cd-476c-ae38-1a2a1c1e6374"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3cf5321-421c-486c-864b-5cb445dd0667"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9fea98a-368c-42eb-92be-e8c7ac153f16"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""79ec3e60-4ce9-4d5c-9d4f-b09ab459171b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4f01effb-c511-4677-8765-a18208e1cd66"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""040a8f1a-eb93-420e-8454-2be03747335d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6eafe722-ded2-4842-9441-1222876918cc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e91778c4-db97-4243-a0df-9f002947e4bb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3f1eef2c-05dc-49d8-88dc-cd2f673fb0c2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3c493a1-4766-4f69-a41f-a6a87b464745"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Diagonal movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Primary
            m_Primary = asset.FindActionMap("Primary", throwIfNotFound: true);
            m_Primary_MoveLeft = m_Primary.FindAction("Move Left", throwIfNotFound: true);
            m_Primary_MoveRight = m_Primary.FindAction("Move Right", throwIfNotFound: true);
            m_Primary_MoveDown = m_Primary.FindAction("Move Down", throwIfNotFound: true);
            m_Primary_MoveUp = m_Primary.FindAction("Move Up", throwIfNotFound: true);
            m_Primary_Ultimate = m_Primary.FindAction("Ultimate", throwIfNotFound: true);
            m_Primary_Diagonalmovement = m_Primary.FindAction("Diagonal movement", throwIfNotFound: true);
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

        // Primary
        private readonly InputActionMap m_Primary;
        private IPrimaryActions m_PrimaryActionsCallbackInterface;
        private readonly InputAction m_Primary_MoveLeft;
        private readonly InputAction m_Primary_MoveRight;
        private readonly InputAction m_Primary_MoveDown;
        private readonly InputAction m_Primary_MoveUp;
        private readonly InputAction m_Primary_Ultimate;
        private readonly InputAction m_Primary_Diagonalmovement;
        public struct PrimaryActions
        {
            private @MainComtrolSchema m_Wrapper;
            public PrimaryActions(@MainComtrolSchema wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveLeft => m_Wrapper.m_Primary_MoveLeft;
            public InputAction @MoveRight => m_Wrapper.m_Primary_MoveRight;
            public InputAction @MoveDown => m_Wrapper.m_Primary_MoveDown;
            public InputAction @MoveUp => m_Wrapper.m_Primary_MoveUp;
            public InputAction @Ultimate => m_Wrapper.m_Primary_Ultimate;
            public InputAction @Diagonalmovement => m_Wrapper.m_Primary_Diagonalmovement;
            public InputActionMap Get() { return m_Wrapper.m_Primary; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PrimaryActions set) { return set.Get(); }
            public void SetCallbacks(IPrimaryActions instance)
            {
                if (m_Wrapper.m_PrimaryActionsCallbackInterface != null)
                {
                    @MoveLeft.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveLeft;
                    @MoveRight.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveRight;
                    @MoveRight.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveRight;
                    @MoveRight.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveRight;
                    @MoveDown.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveDown;
                    @MoveDown.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveDown;
                    @MoveDown.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveDown;
                    @MoveUp.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveUp;
                    @MoveUp.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveUp;
                    @MoveUp.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMoveUp;
                    @Ultimate.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnUltimate;
                    @Ultimate.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnUltimate;
                    @Ultimate.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnUltimate;
                    @Diagonalmovement.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnDiagonalmovement;
                    @Diagonalmovement.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnDiagonalmovement;
                    @Diagonalmovement.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnDiagonalmovement;
                }
                m_Wrapper.m_PrimaryActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveLeft.started += instance.OnMoveLeft;
                    @MoveLeft.performed += instance.OnMoveLeft;
                    @MoveLeft.canceled += instance.OnMoveLeft;
                    @MoveRight.started += instance.OnMoveRight;
                    @MoveRight.performed += instance.OnMoveRight;
                    @MoveRight.canceled += instance.OnMoveRight;
                    @MoveDown.started += instance.OnMoveDown;
                    @MoveDown.performed += instance.OnMoveDown;
                    @MoveDown.canceled += instance.OnMoveDown;
                    @MoveUp.started += instance.OnMoveUp;
                    @MoveUp.performed += instance.OnMoveUp;
                    @MoveUp.canceled += instance.OnMoveUp;
                    @Ultimate.started += instance.OnUltimate;
                    @Ultimate.performed += instance.OnUltimate;
                    @Ultimate.canceled += instance.OnUltimate;
                    @Diagonalmovement.started += instance.OnDiagonalmovement;
                    @Diagonalmovement.performed += instance.OnDiagonalmovement;
                    @Diagonalmovement.canceled += instance.OnDiagonalmovement;
                }
            }
        }
        public PrimaryActions @Primary => new PrimaryActions(this);
        public interface IPrimaryActions
        {
            void OnMoveLeft(InputAction.CallbackContext context);
            void OnMoveRight(InputAction.CallbackContext context);
            void OnMoveDown(InputAction.CallbackContext context);
            void OnMoveUp(InputAction.CallbackContext context);
            void OnUltimate(InputAction.CallbackContext context);
            void OnDiagonalmovement(InputAction.CallbackContext context);
        }
    }
}
