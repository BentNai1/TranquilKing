using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text speakerTextObject;
    public Text speakingTextObject;


    public void ChangeSpeaker(string speakerName)
    {
        speakerTextObject.text = speakerName;
    }

    public void ChangeSpeakingText(string textToDisplay)
    {
        speakingTextObject.text = textToDisplay;
    }
}
