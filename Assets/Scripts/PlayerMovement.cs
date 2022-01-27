using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    float flyingSpeed;
    bool fly = false;

    [SerializeField] TMP_Text countdownText;
    float timer = 5;

    void Update() {
        //Handle time
        timer -= Time.deltaTime;
        int intTimer = (int)timer +1;
        //Debug.Log(timer.ToString());
        //Debug.Log("NOT ACTION!");
        countdownText.text = intTimer.ToString();
        if (timer < 0)
        {
            controller.jumpTimer();
            timer = 5;
        }
        


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
                animator.SetBool("IsJumping", true);
                fly = true;
                //Debug.Log("Is Flying");
            }
            else
            {
                
                fly = false;
                //Debug.Log("Is Stop Flying");
            }
           
        }
        
    }

    public void OnLanding()
    {
        //Debug.Log("Jump a fasle");
        animator.SetBool("IsJumping", false);
    }


    void FixedUpdate() {
        
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump,fly);
        jump = false;
        
    }
}
