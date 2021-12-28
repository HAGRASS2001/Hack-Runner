using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pausescreen;
    public static bool paused;
    //public KeyCode pausebutton;
    void Start()
    {
        paused = false;
        pausescreen.SetActive(false);
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    PauseGame();
        //}
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            PauseGame();
        }
        //else if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        //{
        //    ResumeGame();
        //}

    }

        public void PauseGame()
        {
        Cursor.lockState = CursorLockMode.None;
        pausescreen.SetActive(true);
        paused = true;
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pausescreen.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }
    
    }

