using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    const string GameScene = "Game";
    const string MainMenuScene = "MainMenu";
    const string GameOverScene = "GameOver";
    
    public static int Score = 0, HighScore = 0;
    
    public static void NewGame()
    {
        SceneManager.LoadScene(GameScene);
        Score = 0;
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenuScene);
    }

    public static void GameOver()
    {
        PlayerPrefs.SetInt("HighScore", HighScore);
        SceneManager.LoadScene(GameOverScene, LoadSceneMode.Additive);
    }
}
