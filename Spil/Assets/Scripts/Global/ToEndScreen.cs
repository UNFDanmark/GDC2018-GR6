using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEndScreen : MonoBehaviour {

    public AudioClip winSound;
    public AudioSource winSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Light") || other.CompareTag("Dark"))
        {
            winSource.PlayOneShot(winSound);
            SceneManager.LoadScene("Ending");
        }
    }
}
