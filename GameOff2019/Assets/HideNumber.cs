using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNumber : MonoBehaviour
{
    public bool ShowNumber;
    public bool Stopper = true;
    //public bool Stopper2 = true;
    public GameObject number;
    public bool IsFlagged;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {

        if (FlagChangerBehavior.HasFlag == true && ShowNumber == false && IsFlagged == false)
        {
            Renderer MyRenderer = GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
            MyRenderer.material.SetColor("_Color", Color.red);
            IsFlagged = true;

        }
        else if(IsFlagged == false && FlagChangerBehavior.HasFlag == false)
        {
            ShowNumber = true;
        }
        else if(IsFlagged && FlagChangerBehavior.HasFlag == true)
        {
            Renderer MyRenderer = GetComponent<Renderer>();
            MyRenderer.material.SetColor("_Color", Color.white);
            IsFlagged = false;
        }



    }
    // Update is called once per frame
    void Update()
    {
        if (Stopper == true)
        {
            if (ShowNumber == true)
            {
                number.SetActive(true);
                Stopper = false;
            }
        }
        if (ShowNumber == true)
        {
            Renderer MyRenderer = GetComponent<Renderer>();
            MyRenderer.material.SetColor("_Color", Color.white);
        }
    }
}
