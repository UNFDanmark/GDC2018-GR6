using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CloseGameScript : MonoBehaviour
{
    public GameObject creditSlide;
    private bool isActive= false;
    public AudioSource buttonSource;
    public AudioClip buttonSound;
    public void CloseGame()
    {
        buttonSource.PlayOneShot(buttonSound);
        Application.Quit();
    }
    public void StartGame()
    {
        buttonSource.PlayOneShot(buttonSound);
        SceneManager.LoadScene("Level 1");
    }
    public void ShowCredits()
    {
        buttonSource.PlayOneShot(buttonSound);
        if (!isActive)
        {
            //creditSlide.enabled = true;
            creditSlide.SetActive(true);
            isActive = true;
        }
        else if (isActive)
        {
            //creditSlide.enabled = false;
            creditSlide.SetActive(false);
            isActive = false;
        }
    }
}
