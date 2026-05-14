using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 200f;
    new Rigidbody rigidbody;

    bool isTouchingGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Run();

    }

    void Jump()
    {
        if (isTouchingGround)
        {
            rigidbody.AddForce(0, jumpForce, 0);
        }
    }

    void Run()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * speed * Time.deltaTime, 0, zValue * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
    {
        isTouchingGround = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
    {
        isTouchingGround = false;
        }
    }
}
