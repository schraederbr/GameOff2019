using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberBehavior : MonoBehaviour
{
    public Vector3 NewPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float radius = 0.4f;
        int LayerMask = 1 << 11;
        NewPosition = transform.position;
        NewPosition.x += 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        NewPosition = transform.position;
        NewPosition.x -= 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        NewPosition = transform.position;
        NewPosition.z += 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        NewPosition = transform.position;
        NewPosition.z -= 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }

        //Diagonals
        //Top Right
        NewPosition = transform.position;
        NewPosition.x += 1;
        NewPosition.z += 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        //Top Left
        NewPosition = transform.position;
        NewPosition.x -= 1;
        NewPosition.z += 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        //Bottom Left
        NewPosition = transform.position;
        NewPosition.z -= 1;
        NewPosition.x -= 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
        //Bottom Right
        NewPosition = transform.position;
        NewPosition.z -= 1;
        NewPosition.x += 1;
        if (Physics.CheckSphere(NewPosition, radius, LayerMask))
        {
            GetComponent<HideNumber>().ShowNumber = true;
        }
    }
}
