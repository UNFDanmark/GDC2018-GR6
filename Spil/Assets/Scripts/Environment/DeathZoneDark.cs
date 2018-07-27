using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneDark : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dark")
        {
            Destroy(other.gameObject);
        }
    }
}
