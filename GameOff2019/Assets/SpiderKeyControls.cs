using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add some music or sounds
//Fix the camera
//Possibly add acceleration to spider controls
//Adjust drag and angular drag and speed of spider
public class SpiderKeyControls : MonoBehaviour
{
    public Rigidbody rb;
    public float RightRotation;
    public float ForwardRotation;
    public float RocketSpeed;
    public float RocketLift;
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Implement better input later
        //Jumping
        //if (Input.GetKeyDown("space") && CanJump == true)
        //{
        //    FrogJump();
        //}
        if (Input.GetKey("space"))
        {
            RocketThrust();
        }
        

        //Rotating Left and Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // Debug.Log("Trying to rotate");
            rb.transform.Rotate(0, 0, -RightRotation * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, 0, RightRotation * Time.deltaTime, Space.Self);
        }
        //Rotating Forward and Backward
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // Debug.Log("Trying to rotate");
            rb.transform.Rotate(ForwardRotation * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.transform.Rotate(-ForwardRotation * Time.deltaTime, 0, 0, Space.Self);
        }
    }

    public void RocketThrust()
    {
        
        rb.AddRelativeForce(new Vector3(0,RocketLift* Time.deltaTime,RocketSpeed * Time.deltaTime));
    }
}
