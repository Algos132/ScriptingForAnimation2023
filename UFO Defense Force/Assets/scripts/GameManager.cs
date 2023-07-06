using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;

    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if (isGameOver)
        {
            EndGame(); //Start EndGame method
        }
        else
        {
            {
                gameOverText.gameObject.SetActive(false); //Keeps the Game Over text hidden
            }
        }
    }

    public void EndGame() //Shows the Game Over Text and freezes time
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
}
