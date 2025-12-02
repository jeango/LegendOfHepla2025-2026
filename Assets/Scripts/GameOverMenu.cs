using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        GameManager.StartGame();
    }

    public void ReturnToMainMenu()
    {
        GameManager.LoadMainMenu();
    }
}
