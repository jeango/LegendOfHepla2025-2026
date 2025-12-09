using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;
    public static int highscore = 0;

    public static void NewGame()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("highScore",0);
        SceneManager.LoadScene("Game");
    }

    public static void GameOver()
    {
        PlayerPrefs.SetInt("highScore", highscore);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
