using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;

    public static void NewGame()
    {
        score = 0;
        SceneManager.LoadScene("Game");
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
