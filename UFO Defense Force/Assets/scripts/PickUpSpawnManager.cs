using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class PickUpSpawnManager : MonoBehaviour
{
    public GameObject[] pickUpPrefabs; //Array to store pick up types.
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval;
    private void Start()
    {
        spawnInterval = Random.Range(5, 15); //Spawns the pickup at random intervals between 5 and 15 seconds.
        InvokeRepeating("SpawnRandomPickUp", startDelay, spawnInterval);
    }

    void SpawnRandomPickUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int pickIndex = Random.Range(0, pickUpPrefabs.Length); //picks random pick ups from the array, if different pickups are added
        Instantiate(pickUpPrefabs[pickIndex], spawnPos, pickUpPrefabs[pickIndex].transform.rotation); //spawn an indexed pick up from the array at a random location on the X axis
    }
}