using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText, highscoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.Score.ToString();
        highscoreText.text = GameManager.HighScore.ToString();
    }
}
