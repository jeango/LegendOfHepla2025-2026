using UnityEngine;
using UnityEngine.Events;

public class Berzerkable : MonoBehaviour
{
    public UnityEvent<float> OnBerzerk;
    
    public void Berzerk(float duration)
    {
        OnBerzerk?.Invoke(duration);
    }
}
