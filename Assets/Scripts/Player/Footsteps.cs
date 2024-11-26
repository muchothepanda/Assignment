using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField] AudioSource footsteps;
    [SerializeField] private JumpingModual jumping;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (jumping.Isgrounded())
            {
                footsteps.enabled = true;
            }
            else
            {
                footsteps.enabled= false;
            }
            
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}
