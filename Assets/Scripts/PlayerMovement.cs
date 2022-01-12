using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    float flyingSpeed;
    bool fly = false;

    void Update() {
        
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
        if(Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        else
        {
            if (Input.GetButton("Jump"))
            {
                //animator.SetBool("IsJumping", true);
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

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }


    void FixedUpdate() {
        
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump,fly);
        jump = false;
        
    }
}
