using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPosition;
        NewPosition = this.transform.position;
        NewPosition.z = car.transform.position.z;
        NewPosition.x = car.transform.position.x;
        this.transform.position = NewPosition;
    }
}
