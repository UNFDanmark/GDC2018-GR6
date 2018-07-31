using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour {

    public GameObject source;

	// Use this for initialization
	void Start () {
        if(!GameObject.FindWithTag("Background music"))
        {
            GameObject newSource = Instantiate(source);
            DontDestroyOnLoad(newSource);
        }
               
	}
}
