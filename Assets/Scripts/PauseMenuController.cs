﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{

    public GameObject menu;

    private bool paused;
    private float originalFixedDeltaTime;
    
    void Start()
    {
        paused = false;
        originalFixedDeltaTime = Time.fixedDeltaTime;
        menu.SetActive(false);
    }

    public void PauseGame()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void UnPauseGame()
    {
        paused = !paused;
        menu.SetActive(false);
        Time.timeScale = 1;
        Time.fixedDeltaTime = originalFixedDeltaTime;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    public void GoToMainMenu()
    {
        UnPauseGame();
        SceneManager.LoadScene(0);
    }


    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    public void PauseButton()
    {
        if (paused)
        {
            UnPauseGame();
            paused = !paused;
        }
        else
        {
            PauseGame();
            paused = !paused;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
            {
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
        }
    }
}
