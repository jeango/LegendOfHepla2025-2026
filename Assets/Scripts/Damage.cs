using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        print(collider.gameObject.name);
    }
}
