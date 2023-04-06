using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    public void StartGame()
    {
        print("Starting the Game");
        gameObject.SetActive(false);
    }
    public void GameOverScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
    }
    public void WinningScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
    }
}
