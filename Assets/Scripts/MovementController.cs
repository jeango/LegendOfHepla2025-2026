using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float movementSpeed;

    public void SetDirectionFromInput(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        Move(movementDirection, movementSpeed);
    }

    void Move(Vector3 direction, float speed)
    {
        transform.position += direction.normalized * (Time.deltaTime * speed);
    }

    
}
