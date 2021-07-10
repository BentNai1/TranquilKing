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
    private MiniSceneInfo nextScene;

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


        //_________________________________________ Turn on first scene
        previousScene = firstScene;
        sceneToDisplay = firstScene;
        DisplayScene();
    }


    void Update()
    {
        
    }

    public void BackButtonPress()
    {
        //____________________________________________Go back a scene after pushing back button
        sceneToDisplay = sceneToDisplay.previousScene;
        previousScene = sceneToDisplay.previousScene;
        DisplayScene();
    }

    public void CheckNextSceneButtonPress(int whichButton0_Simp1_Norm2_Dom)
    {
        //____________________________________________Save previous scene for back button interaction ?
        previousScene = sceneToDisplay;
        

        //____________________________________________Set next scene based on button pressed - default to another option if non was set.
        if (whichButton0_Simp1_Norm2_Dom == 0)
        {
            if (sceneToDisplay.nextSceneSimp != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneSimp;
            }
            else if (sceneToDisplay.nextSceneNorm != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneNorm;
            }
            else if (sceneToDisplay.nextSceneDom != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneDom;
            }
            else
            {
                print("Error! There is no scene connected to the current one.");
            }
        }

        if (whichButton0_Simp1_Norm2_Dom == 1)
        {
            if (sceneToDisplay.nextSceneNorm != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneNorm;
            }
            else if (sceneToDisplay.nextSceneDom != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneDom;
            }
            else if (sceneToDisplay.nextSceneSimp != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneSimp;
            }
            else
            {
                print("Error! There is no scene connected to the current one.");
            }
        }

        if (whichButton0_Simp1_Norm2_Dom == 2)
        {
            if (sceneToDisplay.nextSceneDom != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneDom;
            }
            else if (sceneToDisplay.nextSceneSimp != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneSimp;
            }
            else if (sceneToDisplay.nextSceneNorm != null)
            {
                sceneToDisplay = sceneToDisplay.nextSceneNorm;
            }
            else
            {
                print("Error! There is no scene connected to the current one.");
            }
        }

        //____________________________________________Pass saved previous scene to new current scene
        sceneToDisplay.previousScene = previousScene;

        DisplayScene();
    }

    public void DisplayScene()
    {
        //____________________________________________Change visual elements to match scene info
        //...
        //____________________________________________KingSprite
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
        if (sceneToDisplay.speaker != "")
        {
            textController.ChangeSpeaker(sceneToDisplay.speaker);
            print("Speaker text: changed to " + sceneToDisplay.speaker);
        }
        //If value is empty, make no change
        else
        {
            print("Speaker text: no change.");
        }

        //__________________________________________Spoken Text
        if (sceneToDisplay.spokenText != "")
        {
            textController.ChangeSpeakingText(sceneToDisplay.spokenText);
            print("Spoken text: changed to " + sceneToDisplay.spokenText);
        }
        //If value is empty, make no change
        else
        {
            print("Spoken text: no change.");
        }

        //__________________________________________Button 1
        if (sceneToDisplay.button1Text == "")
        //if value is empty, remove text and hide the button
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

        //__________________________________________Button 2
        if (sceneToDisplay.button2Text == "")
        //if value is empty, remove text and hide the button
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

        //__________________________________________Button 3
        if (sceneToDisplay.button3Text == "")
        //if value is empty, remove text and hide the button
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
    }
}
