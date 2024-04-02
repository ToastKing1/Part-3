using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlower : Flower
{
    public GameObject finishedSprite;
    public override ElementalType CheckType()
    {
        return ElementalType.Water;
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
