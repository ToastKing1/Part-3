using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthFlower : Flower
{
    public GameObject finishedSprite;
    public override ElementalType CheckType()
    {
        return ElementalType.Earth;
    }

    protected override void Finished()
    {
        finished = true;
        Instantiate(finishedSprite, sr.transform);
        SceneChanger.flowersFinished += 1;
        if (SceneChanger.flowersFinished > 5)
        {
            SceneChanger.ChangeScene();
        }
    }
}
