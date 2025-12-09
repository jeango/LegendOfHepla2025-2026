using UnityEngine;

public class Damageable : MonoBehaviour
{
    public void TakeDamage()
    {
        ScoreGain gainComponent = GetComponent<ScoreGain>();
        if (gainComponent != null)
        {
            gainComponent.GainScore();            
        }
        Destroy(gameObject);
    }
}
