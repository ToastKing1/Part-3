using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flower : MonoBehaviour
{
    // refernece to the Watering Can
    public WateringCanScript WateringCan;
    // a float to hold the size of the floewr
    public float size;
    // a bool to set if the flower is done growing
    public bool finished = false;
    // the flower sprite
    public SpriteRenderer sr;
    // a bool to check if the flower is growing or not
    bool growing = false;

    // start randomizes the size of the flower
    void Start()
    {
        size = Random.Range(1f, 2.0f);
        // this is to allow size to actually set the flower's scale
        sr.transform.localScale = new Vector3(size, size, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // if the flower is finished, no need to run any more code
        if (finished) return;
        // if the flower is growing, no need to shrink it
        if (growing) return;
        // the flower is capped at 1, otherwise it will shrink over time
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

    // when the flower is clicked on, run this function
    // this function checks if the flower has been clicked on with the correct element
    void OnMouseDown()
    {
        // if the flower is finished, no need to run any more code
        // if the floewr is growing, stop it from being watered again
        if (growing == true || finished) { return; }
        // if its the correct element, grow the flower, otherwise the flower shrinks
        if (CheckType() == WateringCan.currentElement)
        {
            // start the coroutine
            StartCoroutine(Watered(true));
            
        }
        else
        {
            // start the coroutine
            StartCoroutine(Watered(false));
            
        }
        
    }

    // this coroutine grows or shrinks the flower
    IEnumerator Watered(bool isCorrectElement)
    {
        // set growing to true to stop the rest of the code
        growing = true;
        // create the timer
        float timer = 0f;
        // grows when its the correct element, otherwise it shrinks
        if (isCorrectElement)
        {
            while (timer < 2f)
            {
                // if it reaches max size, the flower is finished
                if (size > 5)
                {
                    growing = false;
                    Finished();
                    yield return null;
                    break;
                }
                // the timer grows alongside the size
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
                    // it stops when the size reaches below 1
                    growing = false;
                    yield return null;
                    break;
                }
                // the size shrinks while the timer grows
                timer += Time.deltaTime;
                size -= Time.deltaTime;
                sr.transform.localScale = new Vector3(size, size, 1);
                yield return null;
            }
            growing = false;
        }

    }

    // This method returns the element, it can be overrided
    public virtual ElementalType CheckType()
    {
        // the type will be replaced regardless, therefore I used fire as a default type
        return ElementalType.Fire;
    }

    // this method sets the flower to finished, it can be overrided
    protected virtual void Finished()
    {
        finished = true;
    }

}
