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
        Damageable damageableReference = target.GetComponent<Damageable>();
        if (damageableReference != null)
        {
            if (destroyImmediately)
            {
                Destroy(target);
                return;
            }
            damageableReference.TakeDamage();
        }
    }
}
