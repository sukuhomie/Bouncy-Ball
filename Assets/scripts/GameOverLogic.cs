using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
    public Scene MainGame;
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is DEAD");
    }
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Sail the Seas");
    }
}
