using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;

    private GameObject gameOverText;
    private GameObject gameOverMusic;
    private GameObject gamePlayMusic;


    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverMusic = GameObject.Find("BGMlost");
        gamePlayMusic = GameObject.Find("BGMplaying");

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
                gameOverMusic.gameObject.SetActive(false); //Keeps the object holding the game over music hidden
                gamePlayMusic.gameObject.SetActive(true); //Keeps the looping gameplay object active while game is running
            }
        }
    }

    public void EndGame() //Shows the Game Over Text and freezes time
        {
            gameOverText.gameObject.SetActive(true); 
            gameOverMusic.gameObject.SetActive(true); //plays game over music
            gamePlayMusic.gameObject.SetActive(false); //hides gameplay background music
            Time.timeScale = 0;
        }
}
