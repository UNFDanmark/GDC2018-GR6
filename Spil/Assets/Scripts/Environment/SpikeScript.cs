using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

    public GameOver gM;

    private void Awake()
    {
        gM = FindObjectOfType<GameOver> ();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Dark") || other.gameObject.CompareTag("Light"))
        {
            Destroy(other.gameObject);
            gM.playerIsDead = true;
        }
    }
}
