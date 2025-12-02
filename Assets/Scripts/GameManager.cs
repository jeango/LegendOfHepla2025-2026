using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;
    public static int highscore = 0;
    
    public static void StartGame()
    {
        LoadHighscore();
        SceneManager.LoadScene("Game");
        score = 0;
    }

    static void LoadHighscore()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    static void SaveHighscore()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
            PlayerPrefs.Save();
        }
    }

    public static void GameOver()
    {
        SaveHighscore();
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }
    
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
