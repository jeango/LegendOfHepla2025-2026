using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    void Fire()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    public void FireOnInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Fire();
        }
    }
}
