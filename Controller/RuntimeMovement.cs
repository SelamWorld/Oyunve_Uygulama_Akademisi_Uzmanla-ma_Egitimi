using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class RuntimeMovement : MonoBehaviour
{
    private MovementScript _input;
    private CharacterController _controller;
    public float fraction;
    private Animator _animator;
    // Start is called before the first frame update
    private void Awake()
    {
        Application.targetFrameRate = 100;
    }
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<MovementScript>();        
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
    public void Move(){
        _controller.Move( new Vector3(_input.MoveVal.x * _input.moveSpeed/fraction, 0, _input.MoveVal.y * _input.moveSpeed/fraction));
        _animator.SetFloat("Speed", MathF.Abs(_controller.velocity.x)+ Mathf.Abs(_controller.velocity.z));
        print(_controller.velocity.x +" "+ _controller.velocity.z);
        
    
    }
}
