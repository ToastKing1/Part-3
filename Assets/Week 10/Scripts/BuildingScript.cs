using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public SpriteRenderer pumpkinSr;
    public SpriteRenderer scarecrowSr;
    public SpriteRenderer gravestoneSr;


    public float interpolation = 0f;
    public float interpolationTarget = 2f;

    public void Start()
    {
        StartCoroutine( building());
    }

    IEnumerator building()
    {
        
        while (interpolation < interpolationTarget)
        {
            pumpkinSr.gameObject.transform.localScale = Vector3.Lerp(pumpkinSr.gameObject.transform.localScale, new Vector3(1, 1, 1), (interpolation / interpolationTarget));
            interpolation += 1 * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);

        interpolation = 0f;

        while (interpolation < interpolationTarget)
        {
            scarecrowSr.gameObject.transform.localScale = Vector3.Lerp(scarecrowSr.gameObject.transform.localScale, new Vector3(1, 1, 1), (interpolation / interpolationTarget));
            interpolation += 1 * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);

        interpolation = 0f;

        while (interpolation < interpolationTarget)
        {
            gravestoneSr.gameObject.transform.localScale = Vector3.Lerp(gravestoneSr.gameObject.transform.localScale, new Vector3(1, 1, 1), (interpolation / interpolationTarget));
            interpolation += 1 * Time.deltaTime;
            yield return null;
        }
    }

}
