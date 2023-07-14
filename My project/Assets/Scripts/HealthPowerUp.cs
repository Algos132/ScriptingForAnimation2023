using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyHealth(other.gameObject); //Applies health value to the player
            
            Destroy(gameObject); //Destroys the health power up
        }
    }

    private void ApplyHealth(GameObject player)
    {
        HealthController healthController = player.GetComponent<HealthController>(); //Retrieves the player's health component

        if (healthController != null) //checks if the player has a health component
        {
            healthController.AddHealth(healthValue.Value); //Adds the health value to the player's current health
        }
    }
}
