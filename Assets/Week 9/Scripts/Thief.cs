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
    public float dashSpeed = 7;
    Coroutine dashing;

    protected override void Attack()
    {
        // dash towards mouse
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (dashing != null )
        {
            StopCoroutine( dashing );
        }
        dashing = StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        speed += dashSpeed;
        while(speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, daggerSpawn1.position, daggerSpawn1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, daggerSpawn2.position, daggerSpawn2.rotation);

    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    
}
