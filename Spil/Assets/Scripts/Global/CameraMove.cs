using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    //GameManager gameManager;
    public float cameraSpeed;

	// Use this for initialization
	//void Awake () {
      //  gameManager = GameObject.FindObjectOfType<GameManager>();
	//}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            MoveCamera();
        }
        
	}

    void MoveCamera()
    {
        transform.Translate(0, -23.5f, 0);
    }
}
