using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// all the different elements are put into an enumerator
public enum ElementalType
{
    Fire,
    Water,
    Earth
}

public class WateringCanScript : MonoBehaviour
{
    // the spriterenderer that will swap sprite depending on the element
    public SpriteRenderer currentSprite;
    // the current element
    public ElementalType currentElement;

    // the three different elements
    public Sprite fireIcon;
    public Sprite waterIcon;
    public Sprite earthIcon;


    

    // Update is called once per frame
    void Update()
    {
        // if the player presses "T", the elements swap depending on what is the current element
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (currentElement == ElementalType.Fire)
            {
                currentElement = ElementalType.Water;
                currentSprite.sprite = waterIcon;
            }
            else if (currentElement == ElementalType.Water)
            {
                currentElement = ElementalType.Earth;
                currentSprite.sprite = earthIcon;
            }
            else
            {
                currentElement = ElementalType.Fire;
                currentSprite.sprite = fireIcon;
            }
        }
    }
}
