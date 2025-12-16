using UnityEngine;

public class Damageable : MonoBehaviour
{
    public GameObject deathEffectPrefab;
    public int startingHealth = 1;
    
    private int currentHealth;

    void OnEnable()
    {
        currentHealth = startingHealth;
    }
    
    public void TakeDamage()
    {
        currentHealth--;
        if(currentHealth <= 0) Death();
    }

    void Death()
    {
        GetComponent<ScoreGain>()?.Gain();
        if (deathEffectPrefab != null)
        {
            GameObject deathEffectInstance = Instantiate(deathEffectPrefab, transform.position, Quaternion.identity);
            Destroy(deathEffectInstance, 1f);
        }
        Destroy(gameObject);
    }
}