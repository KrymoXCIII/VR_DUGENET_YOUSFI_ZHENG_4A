using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerInput.OnFootActions _onFoot;

    private PlayerController _controller;
    private PlayerLook _look;
    
    
    void Awake()
    {
        _playerInput = new PlayerInput();
        _onFoot = _playerInput.OnFoot;
        
        _controller = GetComponent<PlayerController>();
        _look = GetComponent<PlayerLook>();
        
        _onFoot.Jump.performed += ctx => _controller.Jump();

    }
    
    void FixedUpdate()
    {
        // Tell the PlayerController to move w/ values from movement action
        _controller.ProcessMove(_onFoot.Movement.ReadValue<Vector2>());
    }

    /*
    private void LateUpdate()
    {
        _look.ProcessLook(_onFoot.Look.ReadValue<Vector2>());
    }
    */

    private void OnEnable()
    {
        _onFoot.Enable();
    }

    private void OnDisable()
    {
        _onFoot.Disable();
    }
}