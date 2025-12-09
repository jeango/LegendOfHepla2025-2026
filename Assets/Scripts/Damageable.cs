using UnityEngine;

public class Damageable : MonoBehaviour
{
    public void TakeDamage()
    {
        Score scoreComponent = GetComponent<Score>();
        if (scoreComponent != null)
        {
            scoreComponent.GainScore();
        }
        Destroy(gameObject);
    }
}
