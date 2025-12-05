using UnityEngine;

public class ScoreGain : MonoBehaviour
{
    public int scoreValue;

    public void GainScore()
    {
        GameManager.Score += scoreValue;
    }
}
