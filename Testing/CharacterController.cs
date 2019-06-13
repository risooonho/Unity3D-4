// Simple controller for unit testing of player's interations with other objects
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController characterController;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(horizontal, 0, vertical));
    }

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
}
