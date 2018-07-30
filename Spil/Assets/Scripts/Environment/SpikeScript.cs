using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

    private GameOver gM;
    private List<GameObject> spikes;

    private void Awake()
    {
        gM = FindObjectOfType<GameOver> ();
        //spikes = FindObjectsOfType<>
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
