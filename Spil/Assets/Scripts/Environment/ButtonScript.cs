using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject currentZone;
    public GameObject newZone;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Light") || collision.gameObject.CompareTag("Dark"))
        {
            currentZone.SetActive(false);
            newZone.SetActive(true);
        }
    }
}
