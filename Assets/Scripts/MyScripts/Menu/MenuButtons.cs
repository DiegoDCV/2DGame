using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject pauseMenu;

    public void LoadScene(int buildIndex)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(buildIndex);
    }
    public void LoadScene(string nameScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nameScene);
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
