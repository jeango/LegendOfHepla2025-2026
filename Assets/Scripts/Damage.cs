using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        DealDamage(other.gameObject);
    }
    
    void DealDamage(GameObject target)
    {
        if (target.tag == "Damageable")
        {
            Destroy(target);
        }
    }
}
