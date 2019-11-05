using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueScaleChanger : MonoBehaviour
{
    public float ScaleChangeAmount;
    public bool ScaleUp;
    // Start is called before the first frame update
    void Start()
    {
        ScaleUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y > 0.05)
        {
            ScaleUp = false;
        }
        if (ScaleUp) {
            Vector3 newScale = transform.localScale;
            newScale.y += ScaleChangeAmount * Time.deltaTime;
            transform.localScale = newScale;
        }
        else
        {
            //Vector3 newScale = transform.localScale;
            //newScale.y -= ScaleChangeAmount * Time.deltaTime;
            //transform.localScale = newScale;
        }
    }
}
