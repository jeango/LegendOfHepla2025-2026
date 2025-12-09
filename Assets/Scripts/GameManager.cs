using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;
    public static int highscore = 0;
    
    public static void StartGame()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        SceneManager.LoadScene("Game");
    }

    public static void GameOver()
    {
        PlayerPrefs.SetInt("Highscore", highscore);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
