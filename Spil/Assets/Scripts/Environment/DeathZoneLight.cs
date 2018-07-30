using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneLight : MonoBehaviour {

    public GameOver gM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Light" && !other.isTrigger)
        {
            Destroy (other.gameObject);
            gM.playerIsDead = true;
        }
    }
}
