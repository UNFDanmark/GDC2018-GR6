using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour {


    [SerializeField]
    private float moveSpeed;
    private Rigidbody p1Rb;
    private AudioSource walk;
    private P1JumpScript jumpScript;

    private void Awake()
    {
        p1Rb = GetComponent<Rigidbody>();
        walk = GetComponent<AudioSource>();
        jumpScript = GetComponent<P1JumpScript>();
    }

    private void FixedUpdate()
    {
        Move(moveSpeed);
    }


    void Move(float speed)
    {

        Vector3 velocityMove = new Vector3(speed * Input.GetAxis("Horizontal"), p1Rb.velocity.y, p1Rb.velocity.z);
        p1Rb.velocity = velocityMove;
        if (p1Rb.velocity.x != 0 && jumpScript.grounded)
        {
            if (!walk.isPlaying)
            {
                walk.Play();
            }
        }
        else
        {
            walk.Stop();
        }
    }

}
