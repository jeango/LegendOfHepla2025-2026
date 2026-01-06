using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public float speed;

    void Update()
    {
        Move(direction);
    }
    
    void Move(Vector3 movementDirection)
    {
        transform.position += movementDirection.normalized * (speed * Time.deltaTime);
    }

    public void SetDirectionFromInput(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}
