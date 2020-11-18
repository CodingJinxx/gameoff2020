using System;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInput : Controls.IMovementActions
{
    public Vector3 Direction { get; set; }

    private readonly Controls controls;
    public PlayerInput()
    {
        controls = new Controls();
        controls.Movement.Enable();
        controls.Movement.SetCallbacks(this);
    }

    ~PlayerInput()
    {
        controls.Movement.Disable();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        Direction = new Vector3(-direction.y, 0.0f, direction.x);
    }

}
