using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flower : MonoBehaviour
{
    public GameObject WateringCan;
    public float size;
    public bool finished;
    public SpriteRenderer sr;


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
        size -= 0.5f * Time.deltaTime;
    }

    void MousePressed()
    {
        
    }
}
