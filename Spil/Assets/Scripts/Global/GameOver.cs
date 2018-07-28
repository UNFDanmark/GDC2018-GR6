using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public string sceneToLoad;

    public bool playerIsDead;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerIsDead)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
	}
}
