using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSpider : MonoBehaviour
{
    public GameObject Spider;
    public Vector3 NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewPosition = this.transform.position;
        NewPosition.z = Spider.transform.position.z-20.0f;
        NewPosition.y = Spider.transform.position.y + 3f;
        this.transform.position = NewPosition;
        this.transform.LookAt(Spider.transform);
    }
}
