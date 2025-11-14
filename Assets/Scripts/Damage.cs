using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        DealDamage(other.gameObject);
    }
    
    void DealDamage(GameObject target)
    {
        if (target.GetComponent<Damageable>())
        {
            Destroy(target);
        }
    }
}
