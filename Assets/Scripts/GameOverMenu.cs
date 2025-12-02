using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        GameManager.NewGame();
    }

    public void ReturnToMainMenu()
    {
        GameManager.LoadMainMenu();
    }
}
