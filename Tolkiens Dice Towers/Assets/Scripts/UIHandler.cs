using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TMP_Text StoneText;
    [SerializeField] TMP_Text MagicText;
    [SerializeField] TMP_Text WaveText;

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
