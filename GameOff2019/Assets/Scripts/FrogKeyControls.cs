using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogKeyControls : MonoBehaviour
{
    public Animator FrogAnimator;
    public bool CanJump;
    public BoxCollider JumpCollider;
    public Rigidbody rb;
    public Vector3 ForceVector;
    public float RightRotation;
    //public float LeftRotation;
    public float ForwardRotation;
    //public float BackwardRotation;
    // Start is called before the first frame update
    void Start()
    {
        CanJump = false;
        FrogAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Implement better input later
        //Jumping
        if (Input.GetKeyDown("space") && CanJump == true)
        {
            FrogJump();
        }
        if (Input.GetKeyDown("space") && CanJump == false)
        {
            StickOutTongue();
        }
            //Rotating Left and Right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // Debug.Log("Trying to rotate");
            rb.transform.Rotate(0, RightRotation * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, -RightRotation * Time.deltaTime, 0, Space.Self);
        }
        if (CanJump == false)
        {
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
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.contacts[0].thisCollider == JumpCollider)
        {
            if (col.gameObject.tag == "Floor")
            {
                Debug.Log("FloorCollision!");
                CanJump = true;
            }
        }
    }
    public void FrogJump()
    {
        FrogAnimator.SetTrigger("Jump");
        rb.AddRelativeForce(ForceVector);
        CanJump = false;
    }
    public void StickOutTongue()
    {

    }
    //void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.tag == "Floor")
    //    {
    //        CanJump = true;
    //    }
    //}
    

}
