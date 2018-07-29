using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoneScript : MonoBehaviour {

    public bool player1Passed;
    public bool player2Passed;

    public CameraMove cM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Light")&& !other.isTrigger)
        {
            player2Passed = true;
            
        }
        if (other.CompareTag("Dark") && !other.isTrigger)
        {
            player1Passed = true;
        }
        if (player1Passed && player2Passed)
        {
            cM.MoveCamera();
        }
    }


   
}
