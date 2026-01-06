using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    void Fire(GameObject projectile)
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }

    public void FireOnInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Fire(projectilePrefab);
        }
    }
    
}
