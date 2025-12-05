using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool destroyImmediately;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        DealDamage(other.gameObject);
    }
    
    void DealDamage(GameObject target)
    {
        Damageable damageable = target.GetComponent<Damageable>();
        if (destroyImmediately == false && damageable != null)
        {
            damageable.TakeDamage();
            return;
        }
        Destroy(target);
    }
}
