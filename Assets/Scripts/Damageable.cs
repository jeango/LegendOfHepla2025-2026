using UnityEngine;

public class Damageable : MonoBehaviour
{
    public GameObject explosionPrefab;
    
    public void TakeDamage()
    {
        ScoreGain gain = GetComponent<ScoreGain>();
        gain?.GainScore();
        if (explosionPrefab)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}
