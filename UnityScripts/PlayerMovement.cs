using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.UIElements.Cursor;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    [SerializeField] float sprintSpeed = 2f;
    [SerializeField] public float jumpForce = 3f;
    [SerializeField]private float gravity = 9.81f;
    public static bool isCrouching = false;


    CharacterController controller;
    private bool isJumping;
    private float moveDirection;
    public static float speed;
    private float mouseX;
    private float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        //Gets movement input from the player. (WASD)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0, moveVertical);

        //Gets mouse data from the player and rotates the player relative to the mouse's location.
        mouseY += Input.GetAxis("Mouse Y");
        mouseX += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(mouseY, mouseX, 0);

        //When Left Shift is pressed the player model moves faster based on the sprintSpeed.
        if (Input.GetButtonUp("Sprint"))
        {
            speed = moveSpeed;
        }
        if (Input.GetButtonDown("Sprint"))
        {
            speed = moveSpeed * sprintSpeed;
        }
        
        //Applies constant downward force
        move.y = moveDirection;

        moveDirection -= 0 + gravity * Time.deltaTime;

        //checks if the player is on the ground and if the player isn't crouching, they will jump when "Space" is hit.
        if (controller.isGrounded)
        {
            if (isCrouching == false)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection = jumpForce;
                }
            }
        }

        //moves the character at the specified speeds.
        controller.Move(move * speed * Time.deltaTime);
    }
}