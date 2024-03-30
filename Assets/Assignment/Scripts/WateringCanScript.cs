using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCanScript : MonoBehaviour
{
    public SpriteRenderer currentSprite;
    public ElementalType elementalType;
    public Sprite fireIcon;
    public Sprite waterIcon;
    public Sprite earthIcon;


    public enum ElementalType
    {
        Fire,
        Water,
        Earth
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (elementalType == ElementalType.Fire)
            {
                elementalType = ElementalType.Water;
                currentSprite.sprite = waterIcon;
            }
            else if (elementalType == ElementalType.Water)
            {
                elementalType = ElementalType.Earth;
                currentSprite.sprite = earthIcon;
            }
            else
            {
                elementalType = ElementalType.Fire;
                currentSprite.sprite = fireIcon;
            }
        }
    }
}
