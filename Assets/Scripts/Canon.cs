using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Fire()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    public void FireFromInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Fire();                       
        }
    }
}
