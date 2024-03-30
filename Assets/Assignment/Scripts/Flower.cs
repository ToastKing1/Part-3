using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flower : MonoBehaviour
{
    public WateringCanScript WateringCan;
    public float size;
    public bool finished = false;
    public SpriteRenderer sr;
    bool growing = false;


    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(0.5f, 2.0f);
        sr.transform.localScale = new Vector3(size, size, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (finished) return;
        if (size <= 0.5f)
        {
            size = 0.5f;
            return;
        }
        else
        {
            if (!growing)
            {
                size -= 0.1f * Time.deltaTime;
            }
        }
        sr.transform.localScale = new Vector3(size, size, 1);
    }

    void OnMouseDown()
    {
        Debug.Log("pressed");
        if (growing == true) { return; }
        if (CheckType() == WateringCan.currentElement)
        {
            Debug.Log("It works");
        }
        
    }

    public virtual ElementalType CheckType()
    {
        // the type will be replaced regardless, therefore I used fire as a default type
        return ElementalType.Fire;
    }

}
