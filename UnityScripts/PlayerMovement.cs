using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]public float moveSpeed = 5f;
	[SerializeField]public float jumpForce = 5f;
	[SerializeField]private float gravity = -9.81f;


	CharacterController controller;
	private Vector3 moveDirection;
	private bool isJumping;
	private float ySpeed;
	

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
		
		Vector3 gravityMove = new Vector3(0, jumpForce, 0);
		Vector3 move = transform.forward * moveVertical + transform.right * moveHorizontal;
		controller.Move(moveSpeed * Time.deltaTime * move);
		ySpeed += Physics.gravity.y * Time.deltaTime;
		
		if(Input.GetButtonDown("jump"))
		{
			ySpeed = jumpForce;
		}
    }	
}