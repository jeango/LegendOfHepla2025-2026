using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float speed;
    public Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        if (body == false || body.bodyType != RigidbodyType2D.Dynamic)
        {
            Move(movementDirection);
        }
    }

    void FixedUpdate()
    {
        if (body && body.bodyType == RigidbodyType2D.Dynamic)
        {
            MoveDynamic(movementDirection);
        }
    }

    void Move(Vector3 direction)
    {
        transform.position += direction.normalized * (Time.deltaTime * speed);
    }

    void MoveDynamic(Vector3 direction)
    {
        body.linearVelocity = direction.normalized * speed;
    }

    public void SetDirectionFromInput(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
}
