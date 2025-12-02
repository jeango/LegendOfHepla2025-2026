using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool canScore;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        DealDamage(collider.gameObject);
    }

    void DealDamage(GameObject target)
    {
        if (target.GetComponent<Damageable>())
        {
            if (canScore)
            {
                ScoreGain gain = target.GetComponent<ScoreGain>();
                gain?.Gain();
            }
            Destroy(target);    
        }
    }
}
