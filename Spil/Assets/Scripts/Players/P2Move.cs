using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Move : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private Rigidbody p2Rb;
    [SerializeField]
    private float jumpForce;

    private bool grounded = true;
    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move(moveSpeed);
        
        if (Input.GetAxis("P2 Jump") > 0 && grounded)
        {
            Jump(jumpForce);
            grounded = false;
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = true;
        }
       
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    void Move(float speed)
    {

        Vector3 velocityMove = new Vector3(speed * Input.GetAxis("P2 Horizontal"), p2Rb.velocity.y, p2Rb.velocity.z);
        p2Rb.velocity = velocityMove;
    }

    void Jump(float force)  
    {
        Vector3 velocityMove = new Vector3(p2Rb.velocity.x, force, p2Rb.velocity.z);
        p2Rb.velocity = velocityMove;
    }
}
