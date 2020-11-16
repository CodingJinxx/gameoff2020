using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputTest : MonoBehaviour, NewControls.ITestActions
{
    private NewControls _newControls;
    // Start is called before the first frame update

    private void Awake()
    {
        _newControls = new NewControls();
    }

    private void OnEnable()
    {
        _newControls.Enable();
        _newControls.Test.SetCallbacks(this);
        _newControls.Test.Enable();
        _newControls.Test.TestAction.Enable();
    }

    private void OnDisable()
    {
        _newControls.Disable();
        _newControls.Test.Disable();
        _newControls.Test.TestAction.Disable();

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestAction(InputAction.CallbackContext context)
    {
        Debug.Log("Button A Pressed");
    }
}
