using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower : Flower
{

    static Sprite finishedSprite;
    public override ElementalType CheckType()
    {
        return ElementalType.Fire;
    }
}
