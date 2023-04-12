using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    BackgroundMusicScript BGMusic;
    GameObject BGMusicObject;

    void Start()
    {
        BGMusicObject = GameObject.Find("BackgroundMusic");
        BGMusic = BGMusicObject.GetComponent<BackgroundMusicScript>();
    }

    public void StartGame()
    {
        print("Starting the Game");
        gameObject.SetActive(false);
        BGMusic.PlayGameplaySound();
    }
    public void GameOverScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
        BGMusic.PlayMainMenuSound();
    }
    public void WinningScreen()
    {
        print("Game Over");
        gameObject.SetActive(true);
        BGMusic.PlayMainMenuSound();
    }
}
