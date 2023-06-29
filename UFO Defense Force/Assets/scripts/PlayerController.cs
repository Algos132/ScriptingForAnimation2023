using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float xRange;
    public float speed;
    public Transform blaster;
    public GameObject laserBolt;
    public static int pickUpOne = 0;

    
    // Update is called once per frame
    void Update()
    {
        //Initializes horizontalInput to recieve values from keyboard.
        horizontalInput = Input.GetAxis("Horizontal");
        
        //Moves Player horizontally (left and right).
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeps player inbounds. (left)
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //keeps player inbounds. (right)
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create laserBolt at the blaster transform position. Maintaining the rotation.
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
        if (pickUpOne > 0f)
        {
            Debug.Log("Inventory " + pickUpOne);
        }
        void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}

