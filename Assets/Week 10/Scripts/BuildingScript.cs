using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public SpriteRenderer pumpkinSr;
    public SpriteRenderer scarecrowSr;
    public SpriteRenderer gravestoneSr;


    public float interpolation = 1f;

    public void Start()
    {
        StartCoroutine( building());
    }

    IEnumerator building()
    {
        print(pumpkinSr.gameObject.transform.localScale);
            pumpkinSr.gameObject.transform.localScale = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(1, 1, 1), interpolation * Time.deltaTime);

        yield return new WaitForSeconds(1.0f);

        scarecrowSr.gameObject.transform.localScale = Vector3.Lerp(scarecrowSr.gameObject.transform.localScale, new Vector3(1, 1, 1), interpolation * Time.deltaTime);

        yield return new WaitForSeconds(1.0f);

        gravestoneSr.gameObject.transform.localScale = Vector3.Lerp(gravestoneSr.gameObject.transform.localScale, new Vector3(1, 1, 1), interpolation * Time.deltaTime);

    }

}
