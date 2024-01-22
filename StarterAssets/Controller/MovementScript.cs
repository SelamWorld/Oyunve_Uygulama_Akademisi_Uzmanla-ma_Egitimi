using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    public Rigidbody Rbody;
    public Vector2 MoveVal;
    public float moveSpeed=10;
    // Start is called before the first frame update
    void Awake()
    {Rbody= GetComponent<Rigidbody>();
        
    }

    public void Moving(InputAction.CallbackContext Value)
    {
        if (Value.performed)
        {
            print("performed");
            MoveVal=Value.ReadValue<Vector2>();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
