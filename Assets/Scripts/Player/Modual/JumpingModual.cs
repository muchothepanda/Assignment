using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingModual : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 Velocity;
    [SerializeField] private LayerMask floorLayer;
    private const float gravityacceleration = -9.81f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Isgrounded())
        {
            Velocity.y = 9.5f;
        }
    }
    public void ApplyGravity()
    {
        if (!Isgrounded())
        {
            Velocity.y += gravityacceleration * Time.deltaTime;
            if (Velocity.y < -10f)
            {
                Velocity.y = -2f;
            }
        }
        else
        {
            if (Velocity.y < 0)
            {
                Velocity.y = 0;
            }
        }
        controller.Move(Velocity * Time.deltaTime);
    }
    public bool Isgrounded()
    {
        return Physics.CheckSphere(transform.position, 0.25f, floorLayer);

    }
}
