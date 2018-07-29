using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2JumpScript : MonoBehaviour {

    [SerializeField]
    private Rigidbody myRigidbody;
    [SerializeField]
    private float jumpForce;

    public bool grounded = true;
    // Use this for initialization
    void Awake () {
        myRigidbody = GetComponentInParent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("P2 Jump") > 0 && grounded)
        {
            Jump(jumpForce);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            grounded = true;
        }

    }
    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Ground")
        {
            grounded = false;
        }
    }

    void Jump(float force)
    {
        Vector3 velocityMove = new Vector3(myRigidbody.velocity.x, force, myRigidbody.velocity.z);
        myRigidbody.velocity = velocityMove;
    }
}
