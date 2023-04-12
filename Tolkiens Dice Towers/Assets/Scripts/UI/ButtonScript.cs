using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] TMP_Text ButtonTextObject;
    [SerializeField] string ButtonText;
    void Start()
    {
        ButtonTextObject.text = ButtonText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
