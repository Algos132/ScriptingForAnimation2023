using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpOutOfBounds : MonoBehaviour
{
    public float lowerBounds = -25.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}