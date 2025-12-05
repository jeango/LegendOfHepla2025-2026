using UnityEngine;

public class Damageable : MonoBehaviour
{
    public void TakeDamage()
    {
        ScoreGain gain = GetComponent<ScoreGain>();
        gain?.GainScore();
        Destroy(gameObject);
    }
}
