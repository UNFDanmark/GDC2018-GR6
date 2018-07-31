using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScriptP1 : MonoBehaviour {


    private void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.eulerAngles = new Vector3(-90, -120, 0);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.eulerAngles = new Vector3(-90, 120, 0);
        }
    }
}
