using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame()
    {
        GameManager.NewGame();
    }

    public void LoadMainMenu()
    {
        GameManager.LoadMainMenu();
    }
}
