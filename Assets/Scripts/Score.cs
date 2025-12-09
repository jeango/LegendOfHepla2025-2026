using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;

    public void GainScore()
    {
        GameManager.score += score;
        if (GameManager.score > GameManager.highscore)
        {
            GameManager.highscore = GameManager.score;
        }
    }
}
