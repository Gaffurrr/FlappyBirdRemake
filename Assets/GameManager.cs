using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject PlayMenuPanel;
    public GameObject PauseMenuCanvas;
    public GameManager gameManager;
    public GameObject PausePanel;
    public GameObject ScorePanel;
    

    private void Start()
    {
        GameOverCanvas.SetActive(false);
        Time.timeScale = 0;
        PlayMenuPanel.SetActive(true);
        PauseMenuCanvas.SetActive(false);
        PausePanel.SetActive(false);
        ScorePanel.SetActive(false);
    }

    public void hebelehubele()
    {
        PlayMenuPanel.SetActive(false);
        Time.timeScale = 1;
        PausePanel.SetActive(true);
        ScorePanel.SetActive(true);
    }
    
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        PausePanel.SetActive(false);
        ScorePanel.SetActive(true);
    }

    public void replay()
    {
            SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0;
        PausePanel.SetActive(false);
        ScorePanel.SetActive(true);
    }

    public void UnPause()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1;
    }



    public void AudioOnOff()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
