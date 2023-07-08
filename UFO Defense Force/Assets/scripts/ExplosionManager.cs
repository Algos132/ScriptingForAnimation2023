using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    public bool hitted;

    private GameObject gameExplosion;

    // Start is called before the first frame update
    void Start()
    {
        gameExplosion = GameObject.Find("ExplosionSFX"); //Finds the Explosion sound effect
        gameExplosion.gameObject.SetActive(false);
    }

    public void Hit()
    {
        if (hitted = true)
        {
            gameExplosion.gameObject.SetActive(true);
            Invoke("Disable", 1);
        }
    }

    private void Disable()
    {
        gameExplosion.gameObject.SetActive(false);
        hitted = false;
    }


}
