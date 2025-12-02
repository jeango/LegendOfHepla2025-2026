using UnityEngine;

public class ScoreGain : MonoBehaviour
{
    public int scoreValue;

    public void Gain()
    {
        GameManager.score += scoreValue;
        Debug.LogFormat($"New Score: {GameManager.score}");
    }
}
