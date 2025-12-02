using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    void Start()
    {
        highScoreText.text = GameManager.highscore.ToString();
    }
    
    void Update()
    {
        scoreText.text = GameManager.score.ToString();
    }
}
