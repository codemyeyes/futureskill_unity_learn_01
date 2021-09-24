using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    CharacterController characterController;
    Animator animator;
    Rigidbody rigidbody;

    public float speed = 6f;
    private Vector3 moveDirection = Vector3.zero;

    

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(characterController.isGrounded);

        if (characterController.isGrounded)
        {
            
            animator.SetBool("Run", false);
            
            moveDirection = new Vector3(Input.GetAxis("Horizontal"),0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                animator.SetBool("Run", true);
            }


        }

    }
}
