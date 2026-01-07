using UnityEngine;

public class Damageable : MonoBehaviour
{
    public GameObject explosionPrefab;
    public void TakeDamage()
    {
        Score scoreComponent = GetComponent<Score>();
        if (scoreComponent)
        {
            scoreComponent.GainScore();
        }

        if (explosionPrefab)
        {
            Object explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, 0.6f);
        }
        Destroy(gameObject);
    }
}
