using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Move : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;
    private Rigidbody p2Rb;
    public AudioSource walk;
    private P2JumpScript jumpScript;

    private void Awake()
    {
        p2Rb = GetComponent<Rigidbody>();
        walk = GetComponent<AudioSource>();
        jumpScript = GetComponent<P2JumpScript>();
    }

    private void FixedUpdate()
    {
        Move(moveSpeed);       
    }


    void Move(float speed)
    {
        
        Vector3 velocityMove = new Vector3(speed * Input.GetAxis("P2 Horizontal"), p2Rb.velocity.y, p2Rb.velocity.z);
        p2Rb.velocity = velocityMove;
        if(p2Rb.velocity.x != 0 && jumpScript.grounded)
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
