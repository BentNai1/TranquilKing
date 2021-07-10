using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button[] button;

    void Start()
    {
        ChangeButton(0, true, "Hello, this is a test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButton(int WhichButton, bool stateIsOn, string buttonText)
    {
        button[WhichButton].enabled = stateIsOn;
        button[WhichButton].GetComponentInChildren<Text>().text = buttonText;
    }
}
