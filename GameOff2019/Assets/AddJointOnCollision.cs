using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO: Determine if Tongue should be trigger
//TODO: Stop tongue growth on collision with platform, could disable script
//TODO: Make tongue come out on space, try to fix weird physics
//TODO: Make sure frog stays attached to tongue, possibly joint them together in the beginning
//TODO: Determine which joint is best. Possibly have disabled join already attached
//TODO: Determine why the collider doesn't match the mesh renderer

public class AddJointOnCollision : MonoBehaviour
{
    public bool hasJoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            if (collision.gameObject.GetComponent<Rigidbody>() != null && !hasJoint)
            {
                Debug.Log("TONGUE JOINT");
                gameObject.AddComponent<CharacterJoint>();
                gameObject.GetComponent<CharacterJoint>().connectedBody = collision.rigidbody;
                hasJoint = true;
                //gameObject.AddComponent<HingeJoint>();
                //gameObject.GetComponent<HingeJoint>().connectedBody = collision.rigidbody;
                //hasJoint = true;
                //light.enabled = false;
                //gameObject.GetComponent<HingeJoint>().maxDistance = 0.001f;
                //gameObject.GetComponent<HingeJoint>().spring = 0.1f;
                //gameObject.GetComponent<HingeJoint>().damper = 100000;
            }
        }
    }
}
