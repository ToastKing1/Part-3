using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementalType
{
    Fire,
    Water,
    Earth
}

public class WateringCanScript : MonoBehaviour
{
    public SpriteRenderer currentSprite;
    public ElementalType currentElement;
    public Sprite fireIcon;
    public Sprite waterIcon;
    public Sprite earthIcon;


    

    // Update is called once per frame
    void Update()
    {
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
