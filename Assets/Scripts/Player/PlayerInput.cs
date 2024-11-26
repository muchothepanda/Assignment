using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private MovementModual movement;
    [SerializeField] private JumpingModual jumping;
   
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
     
        if (movement != null)
        {
            movement.Move();
            movement.Rotate();
        }
        if (movement != null)
        {
            jumping.ApplyGravity();
            jumping.Jump();
        }
    }
}
