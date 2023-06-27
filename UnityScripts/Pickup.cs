using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed = 0.25f;
    private GameObject obj;

    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        obj.GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        //Move game object back
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        
        void OnTriggerEnter(Collider Player)
        {
            Debug.Log ("Pickup collected");
            PlayerController.pickUpOne++;
            Destroy(gameObject);
        }
    }
}