using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.StartGame();        
    }

    public void QuitGame()
    {
        print("Quit Requested");
        Application.Quit();
    }

    public void OpenOptions()
    {
        throw new NotImplementedException();
    }
}
