using UnityEngine;

public class ScoreGain : MonoBehaviour
{
    public int score;
    
    private void OnDestroy()
    {
        GameManager.score += score;
        print ("Score: " + GameManager.score);
    }
}
