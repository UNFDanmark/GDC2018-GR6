using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEndScreen : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Light") && other.CompareTag("Dark"))
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
