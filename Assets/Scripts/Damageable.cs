using UnityEngine;

public class Damageable : MonoBehaviour
{
    public GameObject deathPrefab;
    public int startingHealth = 1;
    
    private int currentHealth;

    void OnEnable()
    {
        currentHealth = startingHealth;
    }
    
    public void TakeDamage()
    {
        ScoreGain gainComponent = GetComponent<ScoreGain>();
        if (gainComponent != null)
        {
            gainComponent.GainScore();            
        }
        currentHealth -= 1;
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        if (deathPrefab != null)
        {
            GameObject explosionInstance = Instantiate(deathPrefab, transform.position, Quaternion.identity);
            Destroy(explosionInstance, 1f);
        }
        Destroy(gameObject);        
    }
}
