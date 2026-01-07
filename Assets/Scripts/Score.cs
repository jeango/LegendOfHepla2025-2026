using UnityEngine;

public class Score : MonoBehaviour
{
    public int value;

    public void GainScore()
    {
        GameManager.score += value;
        GameManager.CheckHighScore();
    }
}
