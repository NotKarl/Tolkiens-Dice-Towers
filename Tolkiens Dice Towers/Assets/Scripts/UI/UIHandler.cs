using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TMP_Text StoneText;
    [SerializeField] TMP_Text MagicText;
    [SerializeField] TMP_Text WaveText;

    public ResourceManager resourceTracker; // declare the resourceTracker variable here

    int waveCount = 1;
    void Start()
    {
        resourceTracker = FindObjectOfType<ResourceManager>(); // find the ResourceTracker component and assign it to the resourceTracker variable
        StoneText.text = resourceTracker.stoneCount.ToString() + " Stone";
        MagicText.text = resourceTracker.magicCount.ToString() + " Magic";
        WaveText.text = "Wave: " + waveCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        StoneText.text = resourceTracker.stoneCount.ToString() + " Stone";
        MagicText.text = resourceTracker.magicCount.ToString() + " Magic";
        WaveText.text = "Wave: " + waveCount.ToString();
    }
}
