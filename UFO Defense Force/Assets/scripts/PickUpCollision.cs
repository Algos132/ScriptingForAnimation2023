using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCollision : MonoBehaviour
{
    private GameObject playerInv;
    private void Awake()
    {
        playerInv = GameObject.FindGameObjectWithTag("Player");
        playerInv.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider playerInv)
    {
        Destroy(gameObject);
        PlayerController.pickUpOne++;
    }
}
