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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0, moveVertical);

        mouseY += Input.GetAxis("Mouse Y");
        mouseX += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(mouseY, mouseX, 0);

        if (Input.GetButtonUp("Sprint"))
        {
            speed = moveSpeed;
        }
        if (Input.GetButtonDown("Sprint"))
        {
            speed = moveSpeed * sprintSpeed;
        }
        
        move.y = moveDirection;
        
        moveDirection -= 0 + gravity * Time.deltaTime;

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

        controller.Move(move * speed * Time.deltaTime);
    }
}