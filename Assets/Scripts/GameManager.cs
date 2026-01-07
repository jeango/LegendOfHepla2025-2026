using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score;
    public static int highScore;

    public static void CheckHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }
    }
    
    public static void NewGame()
    {
        LoadHighScore();
        score = 0;
        SceneManager.LoadScene("Game");
    }
    
    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public static void GameOver()
    {
        CheckHighScore();
        PlayerPrefs.SetInt("HighScore", highScore);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }
    
    public static void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

}
