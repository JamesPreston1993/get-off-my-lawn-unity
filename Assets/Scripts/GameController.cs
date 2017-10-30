using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    public GameObject gameOverPanel;
    private bool gameOver;

    void Start()
    {
        UpdateScore();   
    }

    public void AddToScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    public void UpdateScore()
    {        
        scoreText.text = "Score: " + score;
    }

    public void SetGameOver(bool isGameOver)
    {
        gameOver = isGameOver;
        gameOverPanel.SetActive(isGameOver);
    }

    public bool IsGameOver()
    {
        return gameOver;
    }
}
