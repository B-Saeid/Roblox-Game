using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 200f;
    new Rigidbody rigidbody;
    Animator animator;

    bool isTouchingGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
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
            animator.SetBool("isJumping", true);
            rigidbody.AddForce(0, jumpForce, 0);
        }
    }

    void Run()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        if (xValue != 0.0 || zValue != 0.0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        transform.Translate(xValue * speed * Time.deltaTime, 0, zValue * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("isJumping", false);
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
