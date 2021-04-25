using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public Rigidbody2D rb;


    public float runSpeed = 40f;
    bool jump = false;

    float xMove = 0f;
    float yMove = 0f;


    // Update is called once per frame
    void Update()
    {

        xMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("xSpeed", Mathf.Abs(xMove));
        animator.SetFloat("ySpeed", rb.velocity.y);

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }

    }

    void FixedUpdate() {

        controller.Move(xMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
