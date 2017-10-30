using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    public GameObject gameOverPanel;
    private bool gameOver;

    public Button restartButton;

    void Start()
    {
        UpdateScore();
        restartButton.onClick.AddListener(RestartGame);
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

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
