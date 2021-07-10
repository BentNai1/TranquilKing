using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text speakerTextObject;
    public Text speakingTextObject;

    // Start is called before the first frame update
    void Start()
    {
        ChangeSpeaker("Test");
        ChangeSpeakingText("This is a test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSpeaker(string speakerName)
    {
        speakerTextObject.text = speakerName;
    }

    public void ChangeSpeakingText(string textToDisplay)
    {
        speakingTextObject.text = textToDisplay;
    }
}
