using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;
    private GameObject explode;
    public ExplosionManager explosionManager;
    

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Finds ScoreManager game object and reference ScoreManager script component
        explosionManager = GameObject.Find("ExplosionManager").GetComponent<ExplosionManager>(); //Finds the ExplosionManager Game object and reference ExplosionManager script component

    }
    private void OnTriggerEnter(Collider other) //once the Trigger has been entered record collision in the argument variable "other"
    {
        explosionManager.Invoke("Hit", 0);
        scoreManager.IncreaseScore(scoreToGive); //Increases score
        Destroy(other.gameObject); //Destroys the other game object it hits
        Destroy(gameObject); //Destroys this game object
    }
}