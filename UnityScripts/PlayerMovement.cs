using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]public float moveSpeed = 5f;
	[SerializeField]private float jumpForce = 5f;
	[SerializeField]private float gravity = 9f;


	private CharacterController controller;
	private Vector3 moveDirection;
	private bool isJumping;
	

	// Start is called before the first frame update
	void Start()
	{
		controller = GetComponent"Capsule"();
	}

    // Update is called once per frame
    void Update()
    {
	    Move();
    }
	private void Move()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		if (controller.isGrounded) jumpForce = 0;
		else jumpForce -= gravity * Time.deltaTime;

		Vector3 gravityMove = new Vector3(0, jumpForce, 0);
		Vector3 move = transform.forward * moveVertical + transform.right * moveHorizontal;
		controller.Move(moveSpeed * Time.deltaTime * move);
	}	
}