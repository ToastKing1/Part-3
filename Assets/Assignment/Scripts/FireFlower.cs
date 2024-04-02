using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower : Flower
{
    public GameObject finishedSprite;

    public override ElementalType CheckType()
    {
        return ElementalType.Fire;
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
