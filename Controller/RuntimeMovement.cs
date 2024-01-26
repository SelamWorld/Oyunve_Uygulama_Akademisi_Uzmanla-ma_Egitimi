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
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<MovementScript>();        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
    public void Move(){
        _controller.Move( new Vector3(_input.MoveVal.x * _input.moveSpeed/fraction, 0, _input.MoveVal.y * _input.moveSpeed/fraction));
    
    }
}
