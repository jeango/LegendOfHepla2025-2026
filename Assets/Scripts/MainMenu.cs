using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenOptionsMenu()
    {
        throw new NotImplementedException();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
