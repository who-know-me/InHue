//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Settings/Input Systems/Inputcolour.inputactions
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

public partial class @Inputcolour: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputcolour()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputcolour"",
    ""maps"": [
        {
            ""name"": ""changeColours"",
            ""id"": ""18dac5ec-84a4-41ea-870b-5a825f07ca18"",
            ""actions"": [
                {
                    ""name"": ""cskyblue"",
                    ""type"": ""Button"",
                    ""id"": ""3cde999d-b498-4eef-87c1-18ad3193e647"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cgreen"",
                    ""type"": ""Button"",
                    ""id"": ""cbb1fb81-4df7-4012-93cc-f02231af5e73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cred"",
                    ""type"": ""Button"",
                    ""id"": ""1ed7e244-ed4a-44fd-9513-bf1b6c18771b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cdarkblue"",
                    ""type"": ""Button"",
                    ""id"": ""77676c4b-e0df-43e0-800a-68f11493644c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cyellow"",
                    ""type"": ""Button"",
                    ""id"": ""34d60201-a9cd-4735-b4fd-d1ceb8f9b3a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cpink"",
                    ""type"": ""Button"",
                    ""id"": ""6384d113-4fdc-4c09-ab37-2e4d2ef724a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf3c6620-7412-4ad2-823f-52a14ba56c53"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cskyblue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7f31a36-d607-4188-aab3-cdc6687c7a33"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cgreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""550c8d96-6cf8-405d-a3d6-66fc1dc6a96e"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cred"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b104ffc-d4aa-473d-b08c-ede5bea5b3c8"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cdarkblue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a049a2b8-7054-418a-bdae-53916a596828"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cyellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""508adcff-5a92-460b-b93c-e77a8c835ead"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cpink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // changeColours
        m_changeColours = asset.FindActionMap("changeColours", throwIfNotFound: true);
        m_changeColours_cskyblue = m_changeColours.FindAction("cskyblue", throwIfNotFound: true);
        m_changeColours_cgreen = m_changeColours.FindAction("cgreen", throwIfNotFound: true);
        m_changeColours_cred = m_changeColours.FindAction("cred", throwIfNotFound: true);
        m_changeColours_cdarkblue = m_changeColours.FindAction("cdarkblue", throwIfNotFound: true);
        m_changeColours_cyellow = m_changeColours.FindAction("cyellow", throwIfNotFound: true);
        m_changeColours_cpink = m_changeColours.FindAction("cpink", throwIfNotFound: true);
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

    // changeColours
    private readonly InputActionMap m_changeColours;
    private List<IChangeColoursActions> m_ChangeColoursActionsCallbackInterfaces = new List<IChangeColoursActions>();
    private readonly InputAction m_changeColours_cskyblue;
    private readonly InputAction m_changeColours_cgreen;
    private readonly InputAction m_changeColours_cred;
    private readonly InputAction m_changeColours_cdarkblue;
    private readonly InputAction m_changeColours_cyellow;
    private readonly InputAction m_changeColours_cpink;
    public struct ChangeColoursActions
    {
        private @Inputcolour m_Wrapper;
        public ChangeColoursActions(@Inputcolour wrapper) { m_Wrapper = wrapper; }
        public InputAction @cskyblue => m_Wrapper.m_changeColours_cskyblue;
        public InputAction @cgreen => m_Wrapper.m_changeColours_cgreen;
        public InputAction @cred => m_Wrapper.m_changeColours_cred;
        public InputAction @cdarkblue => m_Wrapper.m_changeColours_cdarkblue;
        public InputAction @cyellow => m_Wrapper.m_changeColours_cyellow;
        public InputAction @cpink => m_Wrapper.m_changeColours_cpink;
        public InputActionMap Get() { return m_Wrapper.m_changeColours; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChangeColoursActions set) { return set.Get(); }
        public void AddCallbacks(IChangeColoursActions instance)
        {
            if (instance == null || m_Wrapper.m_ChangeColoursActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ChangeColoursActionsCallbackInterfaces.Add(instance);
            @cskyblue.started += instance.OnCskyblue;
            @cskyblue.performed += instance.OnCskyblue;
            @cskyblue.canceled += instance.OnCskyblue;
            @cgreen.started += instance.OnCgreen;
            @cgreen.performed += instance.OnCgreen;
            @cgreen.canceled += instance.OnCgreen;
            @cred.started += instance.OnCred;
            @cred.performed += instance.OnCred;
            @cred.canceled += instance.OnCred;
            @cdarkblue.started += instance.OnCdarkblue;
            @cdarkblue.performed += instance.OnCdarkblue;
            @cdarkblue.canceled += instance.OnCdarkblue;
            @cyellow.started += instance.OnCyellow;
            @cyellow.performed += instance.OnCyellow;
            @cyellow.canceled += instance.OnCyellow;
            @cpink.started += instance.OnCpink;
            @cpink.performed += instance.OnCpink;
            @cpink.canceled += instance.OnCpink;
        }

        private void UnregisterCallbacks(IChangeColoursActions instance)
        {
            @cskyblue.started -= instance.OnCskyblue;
            @cskyblue.performed -= instance.OnCskyblue;
            @cskyblue.canceled -= instance.OnCskyblue;
            @cgreen.started -= instance.OnCgreen;
            @cgreen.performed -= instance.OnCgreen;
            @cgreen.canceled -= instance.OnCgreen;
            @cred.started -= instance.OnCred;
            @cred.performed -= instance.OnCred;
            @cred.canceled -= instance.OnCred;
            @cdarkblue.started -= instance.OnCdarkblue;
            @cdarkblue.performed -= instance.OnCdarkblue;
            @cdarkblue.canceled -= instance.OnCdarkblue;
            @cyellow.started -= instance.OnCyellow;
            @cyellow.performed -= instance.OnCyellow;
            @cyellow.canceled -= instance.OnCyellow;
            @cpink.started -= instance.OnCpink;
            @cpink.performed -= instance.OnCpink;
            @cpink.canceled -= instance.OnCpink;
        }

        public void RemoveCallbacks(IChangeColoursActions instance)
        {
            if (m_Wrapper.m_ChangeColoursActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IChangeColoursActions instance)
        {
            foreach (var item in m_Wrapper.m_ChangeColoursActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ChangeColoursActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ChangeColoursActions @changeColours => new ChangeColoursActions(this);
    public interface IChangeColoursActions
    {
        void OnCskyblue(InputAction.CallbackContext context);
        void OnCgreen(InputAction.CallbackContext context);
        void OnCred(InputAction.CallbackContext context);
        void OnCdarkblue(InputAction.CallbackContext context);
        void OnCyellow(InputAction.CallbackContext context);
        void OnCpink(InputAction.CallbackContext context);
    }
}
