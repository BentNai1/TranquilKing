using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSceneInfo : MonoBehaviour
{
    public string speakerText;
    public string spokenText;
    [Header("'hidebutton' to remove a button")]
    public string button1Text;
    public string button2Text;
    public string button3Text;

    public int backgroundNumber;
    public int kingSpriteNumber;

    public MiniSceneInfo nextSceneSimp;
    public MiniSceneInfo nextSceneNorm;
    public MiniSceneInfo nextSceneDom;

    public MiniSceneInfo previousScene;

}
