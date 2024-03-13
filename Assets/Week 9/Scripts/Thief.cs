using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform daggerSpawn1;
    public Transform daggerSpawn2;

    protected override void Attack()
    {
        destination = new Vector2(daggerSpawn1.position.x, gameObject.transform.position.y);

        Instantiate(daggerPrefab, daggerSpawn1.position, daggerSpawn1.rotation);
        Instantiate(daggerPrefab, daggerSpawn2.position, daggerSpawn2.rotation);

        base.Attack();
        
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    
}
