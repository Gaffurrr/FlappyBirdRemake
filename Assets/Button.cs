//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.SocialPlatforms.Impl;

//public class GameManager : MonoBehaviour
//{
//    public GameObject GameOverPanel;
//    public GameObject PlayMenuPanel;

//    private void Start()
//    {
//        GameOverPanel.SetActive(false);
//        Time.timeScale = 0;
//        PlayMenuPanel.SetActive(true);
//    }

//    public void hebelehubele()
//    {
//        Time.timeScale = 1;
//        PlayMenuPanel.SetActive(false);
//    }

//    public void GameOver()
//    {
//        GameOverPanel.SetActive(true);
//        Time.timeScale = 0;
//    }

//    public void replay()
//    {
//        SceneManager.LoadScene(0);
//    }
//}
