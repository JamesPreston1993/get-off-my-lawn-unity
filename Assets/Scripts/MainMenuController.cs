﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    public Button howToButton;
    public Button backButton;

    public GameObject mainPanel;
    public GameObject howToPanel;

    void Start ()
    {
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(QuitGame);
        howToButton.onClick.AddListener(ShowHowToMenu);
        backButton.onClick.AddListener(BackToMainMenu);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void ShowHowToMenu()
    {
        mainPanel.SetActive(false);
        howToPanel.SetActive(true);
    }

    void BackToMainMenu()
    {
        mainPanel.SetActive(true);
        howToPanel.SetActive(false);
    }
}
