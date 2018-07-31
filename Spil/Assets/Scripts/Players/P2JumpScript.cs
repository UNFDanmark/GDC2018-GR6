using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2JumpScript : MonoBehaviour {

    private Rigidbody myRigidbody;
    [SerializeField]
    private float jumpForce;
    private AudioSource jumpSource;
    public bool grounded = true;
    public AudioClip jumpSound;
    // Use this for initialization
    void Awake () {
        myRigidbody = GetComponent<Rigidbody>();
        jumpSource = GetComponent<AudioSource>();
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
        if (other.CompareTag("Ground"))
        {
            grounded = true;
        }

    }
    private void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Ground"))
        {
            jumpSource.PlayOneShot(jumpSound);
            grounded = false;
        }
    }

    void Jump(float force)
    {
        Vector3 velocityMove = new Vector3(myRigidbody.velocity.x, force, myRigidbody.velocity.z);
        myRigidbody.velocity = velocityMove;
    }
}
