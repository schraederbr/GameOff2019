using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKeys : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpForce;
    public bool IsJumping = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, MovementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -MovementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-MovementSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(MovementSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
            this.GetComponent<Rigidbody>().AddForce(0, JumpForce, 0);
            IsJumping = true;

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Number" || collision.gameObject.tag == "Tile")
        {
            IsJumping = false;
        }
    }
}
