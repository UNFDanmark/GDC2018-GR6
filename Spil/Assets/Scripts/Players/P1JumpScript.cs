﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1JumpScript : MonoBehaviour {

    [SerializeField]
    private Rigidbody myRigidbody;
    [SerializeField]
    private float jumpForce;

    public bool grounded;
    // Use this for initialization
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0 && grounded)
        {
            Jump(jumpForce);
        }
    }

    private void OnTriggerEnter(Collider ground)
    {
        if (ground.CompareTag("Ground"))
        {
            grounded = true;
        }

    }
    private void OnTriggerExit(Collider ground)
    {
        if (ground.CompareTag("Ground"))
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
