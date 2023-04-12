using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    BackgroundMusicScript BGMusic;
    GameObject BGMusicObject;
    GameObject EnemySpawner;

    void Start()
    {
        BGMusicObject = GameObject.Find("BackgroundMusic");
        BGMusic = BGMusicObject.GetComponent<BackgroundMusicScript>();

        EnemySpawner = GameObject.Find("EnemySpawner");
    }

    public void StartGame()
    {
        print("Starting the Game");
        gameObject.SetActive(false);
        BGMusic.PlayGameplaySound();
        EnemySpawner.SetActive(true);
    }
    public void GameOverScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
        BGMusic.PlayMainMenuSound();
        EnemySpawner.SetActive(false);
    }
    public void WinningScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
        BGMusic.PlayMainMenuSound();
        EnemySpawner.SetActive(false);
    }
}