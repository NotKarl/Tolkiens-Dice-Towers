using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TMP_Text StoneText;
    public TMP_Text MagicText;
    public TMP_Text WaveText;

    public int stoneCount = 5;
    public int magicCount = 5;
    int waveCount = 1;
    void Start()
    {
        StoneText.text = stoneCount.ToString() + " Stone";
        MagicText.text = magicCount.ToString() + " Magic";
        WaveText.text = "Wave: " + waveCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
