﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1JumpScript : MonoBehaviour {

    [SerializeField]
    private Rigidbody myRigidbody;
    [SerializeField]
    private float jumpForce;
    public bool grounded = true;
    public AudioClip jumpSound;
    private AudioSource jumpSource;
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
            //jumpSource.PlayOneShot(jumpSound);
            Jump(jumpForce);
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Ground"))
        {
            jumpSource.PlayOneShot(jumpSound, 0.75f);
            grounded = true;
        }

    }
    private void OnTriggerExit(Collider c)
    {
        if (c.CompareTag("Ground"))
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
