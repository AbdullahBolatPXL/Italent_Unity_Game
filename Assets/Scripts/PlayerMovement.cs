using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;

    float horizontalmove = 0f;
    bool jump = false;
    

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalmove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            Debug.Log("animator isjumping = true");
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate ()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
