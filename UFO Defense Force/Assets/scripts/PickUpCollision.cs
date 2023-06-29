using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCollision : MonoBehaviour
{
    private GameObject _playerInv;
    private void Awake()
    {
        _playerInv = GameObject.FindGameObjectWithTag("Player");
        _playerInv.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController.pickUpOne += 1;
        Debug.Log("Pickup added");
        Destroy(gameObject);
    }
}
