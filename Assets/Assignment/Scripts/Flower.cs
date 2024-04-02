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
    static bool growing = false;


    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(1f, 2.0f);
        sr.transform.localScale = new Vector3(size, size, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (finished) return;
        if (growing) return;
        if (size <= 1f)
        {
            size = 1f;
            return;
        }
        else
        {
            size -= 0.1f * Time.deltaTime;
        }
        sr.transform.localScale = new Vector3(size, size, 1);
    }

    void OnMouseDown()
    {
        
        if (growing == true || finished) { return; }
        if (CheckType() == WateringCan.currentElement)
        {
            StartCoroutine(Watered(true));
            
        }
        else
        {
            StartCoroutine(Watered(false));
            
        }
        
    }

    IEnumerator Watered(bool isCorrectElement)
    {
        growing = true;
        float timer = 0f;
        if (isCorrectElement)
        {
            while (timer < 2f)
            {
                if (size > 5)
                {
                    growing = false;
                    Finished();
                    yield return null;
                    break;
                }
                timer += Time.deltaTime;
                size += Time.deltaTime;
                sr.transform.localScale = new Vector3(size, size, 1);
                yield return null;
            }
            growing = false;
        }
        else
        {
            while (timer < 1f)
            {
                if (size < 1f)
                {
                    growing = false;
                    yield return null;
                    break;
                }
                timer += Time.deltaTime;
                size -= Time.deltaTime;
                sr.transform.localScale = new Vector3(size, size, 1);
                yield return null;
            }
            growing = false;
        }

    }

    public virtual ElementalType CheckType()
    {
        // the type will be replaced regardless, therefore I used fire as a default type
        return ElementalType.Fire;
    }

    protected virtual void Finished()
    {
        finished = true;
    }

}
