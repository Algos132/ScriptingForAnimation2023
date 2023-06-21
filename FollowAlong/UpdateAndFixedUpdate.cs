using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Tiime.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update Time :" + Time.deltaTime);
    }
}