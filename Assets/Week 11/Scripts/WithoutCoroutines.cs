using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WithoutCoroutines : MonoBehaviour
{
    public GameObject missile;
    public float speed = 5;
    public float turningSpeedReduction = 0.75f;
    public float time = 1;
    public float LegLength;
    public float interpolation = 1;
    Quaternion currentHeading;
    Quaternion newHeading;
    public void MakeTurn(float turn)
    {
        interpolation = 0;
        currentHeading = missile.transform.rotation;
        newHeading = currentHeading * Quaternion.Euler(0, 0, turn);
        
    }

    public void MoveForwards(float length)
    {
        time = 0;
        LegLength = length;
    }

    private void Update()
    {

        Turn();
        Forward(); 

    }

    public void Turn()
    {
        if (time < 1)
        {
            time += Time.deltaTime;
            missile.transform.Translate(transform.right * speed * Time.deltaTime);
        }
        
    }

    public void Forward()
    {
        if (interpolation < 1)
        {
            interpolation += 1 * Time.deltaTime;
            missile.transform.rotation = Quaternion.Lerp(currentHeading, newHeading, interpolation);
            missile.transform.Translate(transform.right * (speed * turningSpeedReduction) * Time.deltaTime);
        }
    }
}
