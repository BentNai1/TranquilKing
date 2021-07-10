using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button[] button;

    public void ChangeButton(int WhichButton, bool stateIsOn, string buttonText)
    {
        button[WhichButton].enabled = stateIsOn;
        button[WhichButton].GetComponentInChildren<Text>().text = buttonText;
    }
}
