using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject AboutWindow;
    public GameObject CreditsWindow;
    public GameObject ExitWindow;
    public GameObject Menu;
    public void PlayGame()
    {
        SceneManager.LoadScene("CutScene 1");
    }

    public void QuitGame()
    {
        ExitWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
    public void ShowAbout()
    {
        AboutWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void ShowCredits()
    {
        CreditsWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void Back()
    {
        CreditsWindow.SetActive(false);
        AboutWindow.SetActive(false);
        ExitWindow.SetActive(false);
        Menu.SetActive(true);

    }
}