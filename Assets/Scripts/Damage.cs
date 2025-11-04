using UnityEngine;

public class Damage : MonoBehaviour
{
    //Ajouter détection de tags pour les cleaners
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        DealDamage(collider.gameObject);
    }

    void DealDamage(GameObject target)
    {
        if (target.tag == "Damageabel" || target.GetComponent<Damageable>())
        {
            Destroy(target);
        }
    }
    
}
