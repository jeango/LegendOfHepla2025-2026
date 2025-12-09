using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool destroyImmediately;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        ApplyDamage(collider.gameObject);
    }

    void ApplyDamage(GameObject target)
    {
        if (destroyImmediately)
        {
            Destroy(target);
            return;
        }
        Damageable damageableTarget = target.GetComponent<Damageable>();
        if(damageableTarget != null)
        {
            damageableTarget.TakeDamage();
            return;
        }
    }
}
