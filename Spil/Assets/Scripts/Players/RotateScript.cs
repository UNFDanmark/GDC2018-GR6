using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    private void Update()
    {
        if (Input.GetAxis("P2 Horizontal") < 0)
        {
            transform.eulerAngles = new Vector3(0, -120, 0);
        }
        else if (Input.GetAxis("P2 Horizontal") > 0)
        {
            transform.eulerAngles = new Vector3(0, 120, 0);
        }
    }
}
