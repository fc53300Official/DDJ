using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    void Update() {
        
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    void FixedUpdate() {
        
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
        
    }
}
