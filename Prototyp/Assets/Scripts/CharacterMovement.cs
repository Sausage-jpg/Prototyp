using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    private void Update()
    {
         horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            Debug.Log("Jump");
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }




}

/**void Update()
{
    Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    moveVelocity = moveInput.normalized * movementSpeed;
}

private void FixedUpdate()
{
    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
}*/