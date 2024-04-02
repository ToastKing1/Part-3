using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlower : Flower
{
    // the finished sprite that is unique to the flower
    public GameObject finishedSprite;

    // this method returns what type the flower is
    public override ElementalType CheckType()
    {
        return ElementalType.Water;
    }

    // this method sets the flower finish, instances the finished sprite
    // and it sets the flowerFinished count higher
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
