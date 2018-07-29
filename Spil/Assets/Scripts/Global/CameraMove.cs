using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    //GameManager gameManager;
    public float cameraSpeed;
    public float targetDistance;
    public float targetPosition;

    private void Awake()
    {
        targetPosition = transform.position.y;
    }

    private void Update()
    {
        if (transform.position.y > targetPosition)
        {
            transform.Translate(0, -cameraSpeed * Time.deltaTime, 0);
            if(transform.position.y < targetPosition)
            {
                transform.position = new Vector3(0, targetPosition, transform.position.z);
            }
        }
    }

    public void MoveCamera()
    {
        targetDistance = 23.5f;
        targetPosition = targetPosition - targetDistance;
        
               
    }
}
