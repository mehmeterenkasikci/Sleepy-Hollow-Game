using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenu;

    public GameObject optionsMenu;

    public GameObject panel;

    public AudioSource theme;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Login");
    }

    public void ShowOptions()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        gameIsPaused = true;
    }

    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }

    public void SetFullScreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void SetMusic(bool isMusic)
    {
        theme.mute = !isMusic;
    }
}
