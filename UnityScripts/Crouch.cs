using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CharacterController PlayerHeight;
    public float normalHeight, crouchHeight;
    private float crouchSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMovement>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            PlayerHeight.height = crouchHeight;
            PlayerMovement.isCrouching = true;
            PlayerMovement.speed -= crouchSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            PlayerHeight.height = normalHeight;
            PlayerMovement.isCrouching = false;
            PlayerMovement.speed += crouchSpeed;
        }
    }
}
