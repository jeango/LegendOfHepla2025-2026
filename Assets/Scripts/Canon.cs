using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;

    public void Fire()
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
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
