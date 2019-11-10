using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagChangerBehavior : MonoBehaviour
{
    public static bool HasFlag = false;
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //HasFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        HasFlag = !HasFlag;
        Debug.Log("HasFlag: " + HasFlag);

    }
}
