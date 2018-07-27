using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour {


    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private Rigidbody p1Rb;
    [SerializeField]
    private float jumpForce;

    private bool grounded;
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Move(moveSpeed);
        if (Input.GetAxis("Jump") > 0 && grounded)
        {
            Jump(jumpForce);
        }
    }

    //de næste to funktioner bruges til at registrere om man er på jorden
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

        Vector3 velocityMove = new Vector3(speed * Input.GetAxis("Horizontal"), p1Rb.velocity.y, p1Rb.velocity.z);
        p1Rb.velocity = velocityMove;
    }
    void Jump(float force)
    {
        Vector3 velocityMove = new Vector3(p1Rb.velocity.x, force, p1Rb.velocity.z);
        p1Rb.velocity = velocityMove;
    }
}
