using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    Vector2 movementInput; 


    // Update is called once per frame
    void Update()
    {
        CheckPlayerInput();
    }

   
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movementInput * (movementSpeed * Time.fixedDeltaTime));
    }

    private void CheckPlayerInput()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
    }

}
