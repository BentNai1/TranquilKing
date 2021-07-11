using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressOpenGame : MonoBehaviour
{
    public void ButtonPressLoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
