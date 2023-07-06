using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Finds ScoreManager game object and reference ScoreManager script component
    }
    private void OnTriggerEnter(Collider other) //once the Trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); //Increases score
        Destroy(gameObject); //Destroys this game object
        Destroy(other.gameObject); //Destroys the other game object it hits
    }
}