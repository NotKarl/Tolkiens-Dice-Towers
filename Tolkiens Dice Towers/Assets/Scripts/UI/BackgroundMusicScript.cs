using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip MainMenuSound;
    public AudioClip GamplayMusicSound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMainMenuSound();
    }

    
    public void PlayMainMenuSound()
    {
        audioSource.PlayOneShot(MainMenuSound);
        Debug.Log("MainMenuSound spielt");
    }

    public void PlayGameplaySound()
    {
        audioSource.PlayOneShot(GamplayMusicSound);
        Debug.Log("Gameplay Sound spielt");
    }
}
