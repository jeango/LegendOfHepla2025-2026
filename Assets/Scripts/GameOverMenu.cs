using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    void OnEnable()
    {
        Time.timeScale = 0;
    }

    void OnDisable()
    {
        Time.timeScale = 1;
    }
    
    public void RestartGame()
    {
        GameManager.NewGame();
    }

    public void ReturnToMainMenu()
    {
        GameManager.LoadMainMenu();
    }
}
