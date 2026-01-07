using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool destroyTargetImmediately;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (destroyTargetImmediately)
        {
            Destroy(other.gameObject);
        }
        else
        {
            DealDamage(other.gameObject);
        }
    }
    
    void DealDamage(GameObject target)
    {
        Damageable damageableComponent = target.GetComponent<Damageable>();
        if (damageableComponent)
        {
            damageableComponent.TakeDamage();
        }
    }
}
