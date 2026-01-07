using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.NewGame();
    }

    public void OpenOptions()
    {
        
    }
    
    public void QuitGame()
    {
        GameManager.QuitGame();
    }
}
