using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.NewGame();
    }

    public void QuitGame()
    {
        print("Quit Requested");
        Application.Quit();
    }

    public void OpenOptionsMenu()
    {
        throw new NotImplementedException();
    }
}
