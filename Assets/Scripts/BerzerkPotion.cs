using UnityEngine;

public class BerzerkPotion : MonoBehaviour
{
    public float duration;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Berzerkable>()?.Berzerk(duration);
        Destroy(gameObject);
    }
}
