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
    public AudioClip click;
    public void PlayGame()
    {
        AudioController.instance.playersingle(click);
        SceneManager.LoadScene("CutScene 1");
    }

    public void QuitGame()
    {
        AudioController.instance.playersingle(click);
        ExitWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void Exit()
    {
        AudioController.instance.playersingle(click);
        Application.Quit();
        Debug.Log("Game Close");
    }
    public void ShowAbout()
    {
        AudioController.instance.playersingle(click);
        AboutWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void ShowCredits()
    {
        AudioController.instance.playersingle(click);
        CreditsWindow.SetActive(true);
        Menu.SetActive(false);
    }
    public void Back()
    {
        AudioController.instance.playersingle(click);
        CreditsWindow.SetActive(false);
        AboutWindow.SetActive(false);
        ExitWindow.SetActive(false);
        Menu.SetActive(true);

    }
}