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
        obj.GetComponent<Inventory>();
    }
    // Update is called once per frame
    void Update()
    {
        //Move game object back
        transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        
        void OnTriggerEnter(Collider Player)
        {
            Debug.Log ("Player gained" + Inventory.pickUpOne + " pickups.");
            Inventory.pickUpOne++;
            Destroy(gameObject);
        }
    }
}
