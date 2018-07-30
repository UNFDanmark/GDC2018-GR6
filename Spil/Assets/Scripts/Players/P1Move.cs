using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour {


    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private Rigidbody p1Rb;
    

    private void FixedUpdate()
    {
        Move(moveSpeed);      
    }

    void Move(float speed)
    {

        Vector3 velocityMove = new Vector3(speed * Input.GetAxis("Horizontal"), p1Rb.velocity.y, p1Rb.velocity.z);
        p1Rb.velocity = velocityMove;
    }
    
}
