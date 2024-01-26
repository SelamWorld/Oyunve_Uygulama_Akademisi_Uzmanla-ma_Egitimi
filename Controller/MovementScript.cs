using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    private Rigidbody capsule;
    public Vector2 MoveVal;
    public float moveSpeed = 5f;
    
    void Awake()
    {
        capsule = GetComponent<Rigidbody>();
    }

    public void Moving(InputAction.CallbackContext Value)
    {
        
        if (Value.performed)
        {
            
            MoveVal =Value.ReadValue<Vector2>();
            //print(MoveVal.x+" "+MoveVal.y);
            //capsule.AddForce(new Vector3(MoveVal.x * moveSpeed,0f,MoveVal.y*moveSpeed ),ForceMode.Impulse);      // hareket kuvveti inputla gelen deðer movespeed ile çarpýlýr             
        }
        if (Value.canceled)
        {
            MoveVal = Value.ReadValue<Vector2>();
        }
                                                                                                                                                                               
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
