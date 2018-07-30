using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneDark : MonoBehaviour {

    public GameOver gM;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dark" && !other.isTrigger)
        {
            Destroy(other.gameObject);
            gM.playerIsDead = true;
        }
    }
}
