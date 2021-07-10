using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public GameObject[] spriteToChange;

    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i < spriteToChange.Length; i++)
        {
            SpriteRenderer spriteTemp = spriteToChange[i].GetComponent<SpriteRenderer>();
            spriteTemp.enabled = false;
        }

        ChangeSprite(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite(int spriteNumber)
    {
        for (int i = 0; i < spriteToChange.Length; i++)
        {
            SpriteRenderer spriteTemp = spriteToChange[i].GetComponent<SpriteRenderer>();
            spriteTemp.enabled = false;
        }

        SpriteRenderer activeSprite = spriteToChange[spriteNumber].GetComponent<SpriteRenderer>();
        activeSprite.enabled = true;
    }
}
