using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    float flyingSpeed;
    bool fly = false;

    void Update() {
        
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")) {
            jump = true; 
        }
        else
        {
            if (Input.GetButton("Jump"))
            {
                fly = true;
                Debug.Log("Is Flying");
            }
            else
            {
                fly = false;
                Debug.Log("Is Stop Flying");
            }
           
        }
        
    }

    void FixedUpdate() {
        
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump,fly);
        jump = false;
        
    }
}
