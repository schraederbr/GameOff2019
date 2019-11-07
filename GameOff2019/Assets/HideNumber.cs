using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNumber : MonoBehaviour
{
    public bool ShowNumber;
    public bool Stopper = true;
    public GameObject number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        ShowNumber = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Stopper == true) {
            if (ShowNumber == true)
            {
                number.SetActive(true);
                Stopper = false;
            }
        }
    }
}
