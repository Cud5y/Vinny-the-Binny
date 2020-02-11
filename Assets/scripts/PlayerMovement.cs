using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public Animator Animator;
    float HorizontalMove = 0f;
    public float RunSpeed = 40f;
    public CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * RunSpeed;
        Animator.SetFloat("Speed",Mathf.Abs(HorizontalMove));
    }

    private void FixedUpdate()
    {
        // Movement
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, false);
    }
}
