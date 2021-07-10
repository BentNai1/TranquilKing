using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public int sceneNumber = 0;
    public int miniSceneNumber = 0;

    public MiniSceneInfo firstScene;

    private MiniSceneInfo sceneToDisplay;
    private MiniSceneInfo previousScene;

    private int currentMainSceneNum;

    public GameObject KingSpritesObject;
    public GameObject BackgroundsObject;
    public GameObject ButtonsObject;
    public GameObject TextObject;

    private SpriteController kingController;
    private SpriteController backgroundController;
    private ButtonController buttonController;
    private TextController textController;



    void Start()
    {
        currentMainSceneNum = sceneNumber;

        

        //_________________________________________ Get scripts for objects
        kingController = KingSpritesObject.GetComponent<SpriteController>();
        backgroundController = BackgroundsObject.GetComponent<SpriteController>();
        buttonController = ButtonsObject.GetComponent<ButtonController>();
        textController = TextObject.GetComponent<TextController>();

        DisplayScene(firstScene);
    }


    void Update()
    {
        
    }

    public void DisplayScene(MiniSceneInfo otherMiniInfo)
    {
        //____________________________________________Set previous scene for back button interaction
        otherMiniInfo.previousScene = sceneToDisplay;
        previousScene = sceneToDisplay;

        //____________________________________________Set current scene
        sceneToDisplay = otherMiniInfo;

        //____________________________________________Change visual elements to match scene info


        //___________________________________________KingSprite
        if(sceneToDisplay.kingSpriteNumber != 0)
        {
            //If number is bigger than ammount of sprites in array, show no sprite.
            if (sceneToDisplay.kingSpriteNumber > kingController.spriteToChange.Length)
            {
                kingController.ClearSprites();
                print("King sprite: cleared.");
            }

            //Otherwise, change active sprite to one indicated.
            else
            {
                kingController.ChangeSprite(sceneToDisplay.kingSpriteNumber);
                print("King sprite: change to sprite " + sceneToDisplay.kingSpriteNumber);
            }
        }
        //If value is zero, make no change
        else
        {
            print("King sprite: no change.");
        }

        //__________________________________________BackGroundSprite
        if (sceneToDisplay.backgroundNumber != 0)
        {
            //If number is bigger than ammount of sprites in array, show no sprite.
            if (sceneToDisplay.backgroundNumber > backgroundController.spriteToChange.Length)
            {
                backgroundController.ClearSprites();
                print("Background sprite: cleared.");
            }

            //Otherwise, change active sprite to one indicated.
            else
            {
                backgroundController.ChangeSprite(sceneToDisplay.backgroundNumber);
                print("Background sprite: change to sprite " + sceneToDisplay.backgroundNumber);
            }
        }
        //If value is zero, make no change
        else
        {
            print("Background sprite: no change.");
        }

        //__________________________________________Speaker Text
        if (sceneToDisplay.speakerText != null)
        {
            textController.ChangeSpeaker(sceneToDisplay.speakerText);
            print("Speaker text: changed to " + sceneToDisplay.speakerText);
        }
        //If value is null, make no change
        else
        {
            print("Speaker text: no change.");
        }

        //__________________________________________Spoken Text
        if (sceneToDisplay.spokenText != null)
        {
            textController.ChangeSpeakingText(sceneToDisplay.spokenText);
            print("Spoken text: changed to " + sceneToDisplay.spokenText);
        }
        //If value is null, make no change
        else
        {
            print("Spoken text: no change.");
        }

        //__________________________________________Button 1
        if (sceneToDisplay.button1Text != null)
            //if value is "hidebutton", remove text and hide the button
            if (sceneToDisplay.button1Text == "hidebutton")
            {
                buttonController.ChangeButton(0, false, " ");
                print("Button1: removed.");
            }
            //display button with text
            else
            {
                buttonController.ChangeButton(0, true, sceneToDisplay.button1Text);
                print("Button1: changed to " + sceneToDisplay.button1Text);
            }        
        //If value is null, make no change
        else
        {
            print("Button1: no change.");
        }

        //__________________________________________Button 2
        if (sceneToDisplay.button2Text != null)
            //if value is "hidebutton", remove text and hide the button
            if (sceneToDisplay.button2Text == "hidebutton")
            {
                buttonController.ChangeButton(1, false, " ");
                print("Button2: removed.");
            }
            //display button with text
            else
            {
                buttonController.ChangeButton(1, true, sceneToDisplay.button2Text);
                print("Button2: changed to " + sceneToDisplay.button2Text);
            }
        //If value is null, make no change
        else
        {
            print("Button2: no change.");
        }

        //__________________________________________Button 3
        if (sceneToDisplay.button3Text != null)
            //if value is "hidebutton", remove text and hide the button
            if (sceneToDisplay.button3Text == "hidebutton")
            {
                buttonController.ChangeButton(2, false, " ");
                print("Button3: removed.");
            }
            //display button with text
            else
            {
                buttonController.ChangeButton(2, true, sceneToDisplay.button3Text);
                print("Button3: changed to " + sceneToDisplay.button3Text);
            }
        //If value is null, make no change
        else
        {
            print("Button3: no change.");
        }
    }
}
