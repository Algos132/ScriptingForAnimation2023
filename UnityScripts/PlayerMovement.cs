using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]public float moveSpeed = 5f;
    [SerializeField]public float jumpForce = 5f;
    [SerializeField]private float gravity = 9.81f;


    CharacterController controller;
    private bool isJumping;
    private float ySpeed;
    private float moveDirection;
	

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(moveHorizontal, 0, moveVertical);

        move.y = moveDirection;
        

        
        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection = jumpForce;
            }
        }
        else
        {
            moveDirection += gravity * Time.deltaTime;
        }
        
        controller.Move(move * moveSpeed * Time.deltaTime);

    }
}