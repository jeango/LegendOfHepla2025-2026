using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private void Awake()
    {
        GameManager.LoadHighScore();
    }

    void DisplayScore()
    {
        scoreText.text = GameManager.score.ToString();
        highScoreText.text = GameManager.highScore.ToString();
    }

    void Update()
    {
        DisplayScore();
    }
}
