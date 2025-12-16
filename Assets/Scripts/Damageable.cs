using UnityEngine;

public class Damageable : MonoBehaviour
{
    public GameObject explosionPrefab;
    
    public void TakeDamage()
    {
        Score scoreComponent = GetComponent<Score>();
        if (scoreComponent != null)
        {
            scoreComponent.GainScore();
        }
        if (explosionPrefab != null)
        {
            GameObject instance = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(instance, 1f);
        }
        Destroy(gameObject);
    }
}
