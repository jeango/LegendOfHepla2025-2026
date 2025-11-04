using UnityEngine;

public class Damage : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        DealDamage(collider.gameObject);
    }

    void DealDamage(GameObject target)
    {
        if (target.GetComponent<Damageable>())
        {
            Destroy(target);    
        }
    }
}
