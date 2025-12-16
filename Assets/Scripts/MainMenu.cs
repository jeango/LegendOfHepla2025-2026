using System;
using UnityEngine;

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
