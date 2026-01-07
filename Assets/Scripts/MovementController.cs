using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public Rigidbody2D body;

    void Update()
    {
        if (!body || body.bodyType != RigidbodyType2D.Dynamic)
        {
            Move(direction);
        }
    }

    void FixedUpdate()
    {
        if (body && body.bodyType == RigidbodyType2D.Dynamic)
        {
            MoveDynamic(direction);
        }
    }
    void MoveDynamic(Vector3 movementDirection)
    {
        body.linearVelocity = movementDirection.normalized * speed;
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
