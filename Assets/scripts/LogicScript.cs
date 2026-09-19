using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    // int is for only round numbers   
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public int pipeCount;
    public Text PipeCountText;
    public float moveSpeed = 5;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        pipeCount = pipeCount + 1;
        scoreText.text = playerScore.ToString();
        PipeCountText.text = pipeCount.ToString("Pipe Count is: " + pipeCount);
    }

    public void restartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
}