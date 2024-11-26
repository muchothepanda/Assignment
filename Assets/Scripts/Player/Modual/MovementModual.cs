using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModual : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] private Camera view;
    [SerializeField] private float speed;
    [SerializeField] private float speedMultiplier;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float mousesensitivity;
    private Vector2 aimdirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    public void Move()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        controller.Move(((transform.right * moveDirection.x) + (transform.forward * moveDirection.z)) * Time.deltaTime * speed);
    }
    public void Rotate()
    {
        aimdirection.x = Input.GetAxisRaw("Mouse X");
        aimdirection.y += -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mousesensitivity;

        aimdirection.y = Mathf.Clamp(aimdirection.y, -85f, 85f);

        view.transform.localEulerAngles = new Vector3(aimdirection.y, 0, 0);
        transform.Rotate(Vector3.up, aimdirection.x * Time.deltaTime * mousesensitivity);
    }
}
