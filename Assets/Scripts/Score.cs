using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;

    private void OnDestroy()
    {
        GameManager.score += score;
    }
}
