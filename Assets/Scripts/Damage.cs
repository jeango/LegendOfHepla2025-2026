using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool destroyImmediately;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        DealDamage(collider.gameObject);
    }

    void DealDamage(GameObject target)
    {
        if (destroyImmediately)
        {
            Destroy(target);
            return;
        }
        Damageable damageableComponent = target.GetComponent<Damageable>();
        if (damageableComponent != null)
        {
            damageableComponent.TakeDamage();
        }
    }
    
}
