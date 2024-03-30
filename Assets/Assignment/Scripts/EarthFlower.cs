using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthFlower : Flower
{
    public override ElementalType CheckType()
    {
        return ElementalType.Earth;
    }
}
