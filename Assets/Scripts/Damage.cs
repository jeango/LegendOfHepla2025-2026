using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        ApplyDamage(collider.gameObject);
    }

    void ApplyDamage(GameObject target)
    {
        
        if(target.tag == "Damageable" || target.GetComponent<Damageable>())
        {
            Destroy(target);
        }
    }
}
