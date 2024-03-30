using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlower : Flower
{
    public override ElementalType CheckType()
    {
        return ElementalType.Water;
    }
}
