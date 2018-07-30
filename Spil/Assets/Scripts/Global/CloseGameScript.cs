using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CloseGameScript : MonoBehaviour
{
    public GameObject creditSlide;
    private bool isActive= false;
    public void CloseGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void ShowCredits()
    {
        if (!isActive)
        {
            creditSlide.gameObject.SetActive(true);
            isActive = true;
        }
        if (isActive)
        {
            creditSlide.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
