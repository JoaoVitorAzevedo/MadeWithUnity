using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    // Use this for initialization
    
         public float speed = 5.0F;
         public float rotateSpeed = 3.0F;
         public float jumpSpeed = 8.0F;
         public float gravity = 20.0F;
         private Vector3 moveDirection =  Vector3.zero;
         private CharacterController controller;

    public AnimationClip attack;
    public AnimationClip damaged;
    public AnimationClip walk;
    public AnimationClip jump;
    public AnimationClip idle;



    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal") * speed;
        // Update is called once per frame        
       /*  transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed); */
        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

                }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        }
    }









