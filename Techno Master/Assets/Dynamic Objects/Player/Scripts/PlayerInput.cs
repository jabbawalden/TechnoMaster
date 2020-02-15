using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    PlayerControl controls;
    public Vector2 move;
    public Vector2 aim;  

    private void Awake()
    {
        controls = new PlayerControl();

        controls.PlayerInput.YButton.performed += ctx => YButtonAction();

        controls.PlayerInput.LeftStick.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.PlayerInput.LeftStick.canceled += ctx => move = Vector2.zero;

        controls.PlayerInput.RightStick.performed += ctx => aim = ctx.ReadValue<Vector2>();
        controls.PlayerInput.RightStick.canceled += ctx => aim = Vector2.zero;
    }


    void YButtonAction()
    {
        print("Y Button Pressed");
    }

    void OnEnable()
    {
        controls.PlayerInput.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerInput.Disable();
    }
}
