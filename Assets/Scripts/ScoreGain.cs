using UnityEngine;

public class ScoreGain : MonoBehaviour
{
    public int scoreValue;

    public void GainScore()
    {
        GameManager.Score += scoreValue;
        if (GameManager.Score > GameManager.HighScore)
        {
            GameManager.HighScore = GameManager.Score;
        }
    }
}
